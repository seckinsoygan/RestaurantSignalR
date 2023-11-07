using SignalR.EntityLayer.Abstract;

namespace SignalR.EntityLayer.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
