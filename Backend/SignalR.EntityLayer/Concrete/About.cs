using SignalR.EntityLayer.Abstract;

namespace SignalR.EntityLayer.Concrete
{
    public class About : BaseEntity
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
