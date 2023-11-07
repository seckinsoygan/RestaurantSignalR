using SignalR.EntityLayer.Abstract;

namespace SignalR.EntityLayer.Concrete
{
    public class Feature : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
