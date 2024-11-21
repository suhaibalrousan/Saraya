using Saraya.Kernal.Domain.Base;

namespace Saraya.Kernal.Domain.Saraya
{
    public class Category : EntityBase<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
