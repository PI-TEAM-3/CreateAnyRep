using AutoMapper;

namespace Finance.Repository.Profiles
{
    public class DomainToSqlProfile : Profile
    {
        public DomainToSqlProfile()
        {
            CreateMap<Models.FinanceOperation, ViewModel.FinanceOperation>()
                .ForMember(x => x.TypeOperation, y => y.MapFrom(z => z.TypeOperation));
            CreateMap<Models.TypeOperation, ViewModel.TypeOperation>();
        }
    }
}
