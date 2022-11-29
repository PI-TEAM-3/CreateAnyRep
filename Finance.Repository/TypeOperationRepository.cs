using AutoMapper;
using Finance.Infrastructure;
using Finance.Models;
using System.Threading.Tasks;

namespace Finance.Repository
{
    public class TypeOperationRepository : ITypeOperationRepository
    {
        private readonly FinanceContext _db;
        private readonly IMapper _mapper;

        public TypeOperationRepository(FinanceContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(ViewModel.TypeOperation operation)
        {
            await _db.TypeOperations.AddAsync(_mapper.Map<TypeOperation>(operation));
        }
    }
}
