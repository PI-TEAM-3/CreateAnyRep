using Finance.Infrastructure;
using Finance.Models;
using System.Threading.Tasks;

namespace Finance.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly FinanceContext _dbContext;

        public RepositoryManager(FinanceContext dbContext, 
            IFinanceOperationRepository financeOperationRepository, 
            ITypeOperationRepository typeOperationRepository)
        {
            _dbContext = dbContext;
            FinanceOperation = financeOperationRepository;
            TypeOperation = typeOperationRepository;
        }

        public IFinanceOperationRepository FinanceOperation { get; }

        public ITypeOperationRepository TypeOperation { get; }

        public Task SaveChangesAsync() => _dbContext.SaveChangesAsync();
    }
}
