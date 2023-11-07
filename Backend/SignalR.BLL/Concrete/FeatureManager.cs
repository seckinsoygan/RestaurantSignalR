using SignalR.BLL.Abstract;
using SignalR.DAL.Abstract;
using SignalR.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace SignalR.BLL.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal FeatureDal;
        public FeatureManager(IFeatureDal FeatureDal)
        {
            this.FeatureDal = FeatureDal;
        }

        public async Task AddAsync(Feature entity)
        {
            await FeatureDal.AddAsync(entity);
        }

        public async Task DeleteAsync(Feature entity)
        {
            await FeatureDal.DeleteAsync(entity);
        }

        public async Task<List<Feature>> GetAllAsync(Expression<Func<Feature, bool>> filter = null)
        {
            return await FeatureDal.GetAllAsync();
        }

        public async Task<Feature> GetAsync(Expression<Func<Feature, bool>> filter)
        {
            return await FeatureDal.GetAsync(filter);
        }

        public async Task UpdateAsync(Feature entity)
        {
            await FeatureDal.UpdateAsync(entity);
        }
    }
}
