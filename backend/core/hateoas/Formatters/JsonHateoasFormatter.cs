using hateoas.infrastructure;
using hateoas.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core.seedwork.interfaces;

namespace hateoas.formatters
{
    public class JsonHateoasFormatter : OutputFormatter
    {
        public JsonHateoasFormatter()
        {
            SupportedMediaTypes.Add("application/json; charset=utf-8");
            SupportedMediaTypes.Add("application/json");
        }
        private T GetService<T>(OutputFormatterWriteContext context)
        {
            return (T)context.HttpContext.RequestServices.GetService(typeof(T));
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            var options = GetService<IOptions<HateoasOptions>>(context).Value;

            var hateoasOptionsService = GetService<IHateoasOptionsService>(context);

            if (hateoasOptionsService != null)
                options = hateoasOptionsService.GetHateoas();

            var user = GetService<IUser>(context);
            var contextAccessor = GetService<IActionContextAccessor>(context);
            var urlHelperFactory = GetService<IUrlHelperFactory>(context); 
            var actionDescriptorProvider = GetService<IActionDescriptorCollectionProvider>(context);
            var urlHelper = urlHelperFactory.GetUrlHelper(contextAccessor.ActionContext);
            var response = context.HttpContext.Response;

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            var resource = default(Resource);
            
            if (context.Object is SerializableError error)
            {
                var errorOutput = JsonConvert.SerializeObject(error, serializerSettings);
                response.ContentType = "application/json";
                return response.WriteAsync(errorOutput);
            }
            
            var result = context.Object;

            if (context.ObjectType.GetInterfaces().Contains(typeof(IEnumerable)))
            {
                var listType = context.ObjectType.GetGenericArguments().First();

                var resourceList = ((IEnumerable<object>)result)
                    .Select(r => CreateResource(listType, r, options, actionDescriptorProvider, urlHelper))
                    .ToList();
                resource = CreateResource(context.ObjectType, resourceList, options, actionDescriptorProvider, urlHelper);
            }
            else
            {
                resource = CreateResource(context.ObjectType, context.Object, options, actionDescriptorProvider, urlHelper);
            }
            var output = JsonConvert.SerializeObject(resource, serializerSettings);
            response.ContentType = "application/json";
            return response.WriteAsync(output);
        }

        private static Resource CreateResource(Type type, object value, HateoasOptions options, IActionDescriptorCollectionProvider actionDescriptorProvider, IUrlHelper urlHelper)
        {
            var resourceOptions = options.Requirements.Where(r => r.ResourceType == type);
            var isEnumerable = type.GetInterfaces().Contains(typeof(IEnumerable));

            var resource = default(Resource);
            if (isEnumerable)
            {
                resource = new ListItemResource(value);
            }
            else
            {
                resource = new ObjectResource(value);
            }
            foreach (var option in resourceOptions)
            {
                var route = actionDescriptorProvider.ActionDescriptors.Items.FirstOrDefault(i => i.AttributeRouteInfo.Name == option.Name);
                var method = route.ActionConstraints.OfType<HttpMethodActionConstraint>().First().HttpMethods.First();
                var routeValues = default(object);
                if (!isEnumerable)
                {
                    routeValues = option.RouteValues(value);
                }
                var url = urlHelper.Link(option.Name, routeValues).ToLower();
                resource.Links.Add(new Link(option.Name, url, method));
            }
            return resource;
        }
    }
}
