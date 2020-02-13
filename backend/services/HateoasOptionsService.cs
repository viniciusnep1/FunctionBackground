using hateoas.infrastructure;

namespace services
{
    public class HateoasOptionsService : IHateoasOptionsService
    {
        public HateoasOptions GetHateoas()
        {
            var hateoas = new HateoasOptions();

            return hateoas;
        }
    }
}
