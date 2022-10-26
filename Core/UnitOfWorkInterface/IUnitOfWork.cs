namespace Core.UnitOfWorkInterface
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
