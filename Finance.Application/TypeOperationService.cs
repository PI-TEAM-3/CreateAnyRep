using Finance.Infrastructure;
using Finance.ViewModel;
using System.Threading.Tasks;

namespace Finance.Application
{
    public class TypeOperationService : ITypeOperationService
    {
        private readonly IRepositoryManager _repository;

        public TypeOperationService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(TypeOperation operation)
        {
            await _repository.TypeOperation.CreateAsync(operation);
            await _repository.SaveChangesAsync();
        }
    }
}
