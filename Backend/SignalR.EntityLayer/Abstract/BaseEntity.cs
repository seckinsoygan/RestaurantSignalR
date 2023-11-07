using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
