using System.Threading.Tasks;

namespace Finance.Infrastructure
{
    public interface IRepositoryManager
    {
        IFinanceOperationRepository FinanceOperation { get; }
        ITypeOperationRepository TypeOperation { get; }
        Task SaveChangesAsync();
    }
}
