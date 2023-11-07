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
            FeatureDal.Add(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var value = FeatureDal.GetById(id);
            FeatureDal.Delete(value);
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
            FeatureDal.Update(entity);
        }
    }
}
