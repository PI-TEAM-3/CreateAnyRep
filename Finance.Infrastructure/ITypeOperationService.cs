using Finance.ViewModel;
using System.Threading.Tasks;

namespace Finance.Infrastructure
{
    public interface ITypeOperationService
    {
        Task CreateAsync(TypeOperation operation);
    }
}
