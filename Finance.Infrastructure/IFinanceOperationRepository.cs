using Finance.ViewModel;
using System.Threading.Tasks;

namespace Finance.Infrastructure
{
    public interface IFinanceOperationRepository
    {
        Task CreateAsync(FinanceOperation operation);
    }
}
