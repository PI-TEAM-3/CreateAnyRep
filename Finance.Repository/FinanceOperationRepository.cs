using System.Threading.Tasks;
using AutoMapper;
using Finance.Infrastructure;
using Finance.Models;


namespace Finance.Repository
{
    public class FinanceOperationRepository : IFinanceOperationRepository
    {
        private readonly FinanceContext _db;
        private readonly IMapper _mapper;

        public FinanceOperationRepository(FinanceContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(ViewModel.FinanceOperation operation)
        {
            await _db.Operations.AddAsync(_mapper.Map<FinanceOperation>(operation));
        }
    }
}
