using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Standart.Models;
using Standart.Services;

[ApiController]
[Route("api/[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;
    private readonly IMapper _mapper;

    public AddressController(IAddressService addressService, IMapper mapper)
    {
        _addressService = addressService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetStandardizedAddress([FromQuery] string address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            return BadRequest("Адрес не должен быть пустым");
        }

        var result = await _addressService.CleanAddressAsync(address);
        if (result == null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка при обработке запроса");
        }

        return Ok(result);
    }
}
