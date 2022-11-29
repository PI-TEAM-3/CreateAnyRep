using Finance.ViewModel;
using System.Threading.Tasks;

namespace Finance.Infrastructure
{
    public interface IFinanceOperationService
    {
        Task CreateAsync(FinanceOperation operation);
    }
}
