using SignalR.DAL.Abstract;
using SignalR.DAL.Shared;
using SignalR.DAL.UnitOfWorks;
using SignalR.EntityLayer.Concrete;

namespace SignalR.DAL.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
