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

        public async Task AddAsync(Contact entity)
        {
            await ContactDal.AddAsync(entity);
        }

        public async Task DeleteAsync(Contact entity)
        {
            await ContactDal.DeleteAsync(entity);
        }

        public async Task<List<Contact>> GetAllAsync(Expression<Func<Contact, bool>> filter = null)
        {
            return await ContactDal.GetAllAsync();
        }

        public async Task<Contact> GetAsync(Expression<Func<Contact, bool>> filter)
        {
            return await ContactDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Contact entity)
        {
            await ContactDal.UpdateAsync(entity);
        }
    }
}
