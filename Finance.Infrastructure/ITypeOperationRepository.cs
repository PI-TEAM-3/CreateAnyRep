using Finance.ViewModel;
using System.Threading.Tasks;

namespace Finance.Infrastructure
{
    public interface ITypeOperationRepository
    {
        Task CreateAsync(TypeOperation operation);
    }
}
