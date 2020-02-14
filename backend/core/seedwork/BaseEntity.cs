using System;
using System.ComponentModel.DataAnnotations;

namespace core.seedwork
{
    public interface IEntidadeBase
    {

    }

    public interface IEntidadeBase<T> : IEntidadeBase
    {
        T Id { get; set; }
    }

    public abstract class BaseEntity<T> : IEntidadeBase<T>
    {
        [Key]
        [Required]
        public T Id { get; set; }

        public static bool operator == (BaseEntity<T> left, BaseEntity<T> right)
        {
            if (Equals(left, null))
                return (Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(BaseEntity<T> left, BaseEntity<T> right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseEntity<T>))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            var item = (BaseEntity<T>)obj;

             return item.Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }

    public abstract class EntidadeBase : BaseEntity<Guid>
    {
        /// <summary>
        /// Desativado
        /// </summary>
        public bool Desativado { get; set; }
    }
}
