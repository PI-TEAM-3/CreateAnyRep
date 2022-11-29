using Finance.Infrastructure;
using Finance.ViewModel;
using System.Threading.Tasks;

namespace Finance.Application
{
    public class FinanceOperationService : IFinanceOperationService
    {
        private readonly IRepositoryManager _repository;

        public FinanceOperationService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(FinanceOperation operation)
        {
            await _repository.FinanceOperation.CreateAsync(operation);
            await _repository.SaveChangesAsync();
        }
    }
}
