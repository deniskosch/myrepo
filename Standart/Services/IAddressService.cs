using Standart.Models;

namespace Standart.Services
{
    public interface IAddressService
    {
        Task<DadataResponseModel> CleanAddressAsync(string rawAddress);
    }

}
