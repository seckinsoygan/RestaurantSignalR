namespace SignalR.DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync();
        void SaveChanges();
        void Dispose();
    }
}
