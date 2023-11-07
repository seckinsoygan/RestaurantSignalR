using SignalR.EntityLayer.Abstract;

namespace SignalR.EntityLayer.Concrete
{
    public class Contact : BaseEntity
    {
        public string Location { get; set; }
        public string PhoneNo { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
    }
}
