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
            await SocialMediaDal.AddAsync(entity);
        }

        public async Task DeleteAsync(SocialMedia entity)
        {
            await SocialMediaDal.DeleteAsync(entity);
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
            await SocialMediaDal.UpdateAsync(entity);
        }
    }
}
