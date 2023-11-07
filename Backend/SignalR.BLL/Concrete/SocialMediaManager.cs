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

        public void Add(SocialMedia entity)
        {
            SocialMediaDal.Add(entity);
        }

        public void Delete(SocialMedia entity)
        {
            SocialMediaDal.Delete(entity);
        }

        public async Task<List<SocialMedia>> GetAllAsync(Expression<Func<SocialMedia, bool>> filter = null)
        {
            return await SocialMediaDal.GetAllAsync();
        }

        public async Task<SocialMedia> GetAsync(Expression<Func<SocialMedia, bool>> filter)
        {
            return await SocialMediaDal.GetAsync(filter);
        }

        public void Update(SocialMedia entity)
        {
            SocialMediaDal.Update(entity);
        }
    }
}
