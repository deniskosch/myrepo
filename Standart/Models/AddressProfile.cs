using AutoMapper;

namespace Standart.Models
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<DadataResponseModel, AddressResponse>();
        }
    }

}
