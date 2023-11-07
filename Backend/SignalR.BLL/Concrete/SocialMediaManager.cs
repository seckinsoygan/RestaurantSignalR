using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal SocialMediaDal;
        public SocialMediaManager(ISocialMediaDal SocialMediaDal)
        {
            this.SocialMediaDal = SocialMediaDal;
        }

        public async Task AddAsync(SocialMedia entity)
        {
            SocialMediaDal.Add(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var value = SocialMediaDal.GetById(id);
            SocialMediaDal.Delete(value);
        }

        public async Task<List<SocialMedia>> GetAllAsync(Expression<Func<SocialMedia, bool>> filter = null)
        {
            return await SocialMediaDal.GetAllAsync();
        }

        public async Task<SocialMedia> GetAsync(Expression<Func<SocialMedia, bool>> filter)
        {
            return await SocialMediaDal.GetAsync(filter);
        }

        public async Task UpdateAsync(SocialMedia entity)
        {
            SocialMediaDal.Update(entity);
        }
    }
}
