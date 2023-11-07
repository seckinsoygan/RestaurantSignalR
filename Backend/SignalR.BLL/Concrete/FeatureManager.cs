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

        public void Add(Feature entity)
        {
            FeatureDal.Add(entity);
        }

        public void Delete(Feature entity)
        {
            FeatureDal.Delete(entity);
        }

        public async Task<List<Feature>> GetAllAsync(Expression<Func<Feature, bool>> filter = null)
        {
            return await FeatureDal.GetAllAsync();
        }

        public async Task<Feature> GetAsync(Expression<Func<Feature, bool>> filter)
        {
            return await FeatureDal.GetAsync(filter);
        }

        public void Update(Feature entity)
        {
            FeatureDal.Update(entity);
        }
    }
}
