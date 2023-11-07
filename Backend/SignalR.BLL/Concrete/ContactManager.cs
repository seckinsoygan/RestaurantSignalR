using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal ContactDal;
        public ContactManager(IContactDal ContactDal)
        {
            this.ContactDal = ContactDal;
        }

        public void Add(Contact entity)
        {
            ContactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            ContactDal.Delete(entity);
        }

        public async Task<List<Contact>> GetAllAsync(Expression<Func<Contact, bool>> filter = null)
        {
            return await ContactDal.GetAllAsync();
        }

        public async Task<Contact> GetAsync(Expression<Func<Contact, bool>> filter)
        {
            return await ContactDal.GetAsync(filter);
        }

        public void Update(Contact entity)
        {
            ContactDal.Update(entity);
        }
    }
}
