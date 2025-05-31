namespace Application.Contracts.Data
{
    public interface IContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
