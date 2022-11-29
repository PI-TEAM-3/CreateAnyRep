using AutoMapper;

namespace Finance.Repository.Profiles
{
    public class SqlToDomainProfile : Profile
    {
        public SqlToDomainProfile()
        {
            CreateMap<ViewModel.FinanceOperation, Models.FinanceOperation>()
                .ForMember(x => x.TypeOperation, y => y.MapFrom(z => z.TypeOperation));
            CreateMap<ViewModel.TypeOperation, Models.TypeOperation>();
        }
    }
}
