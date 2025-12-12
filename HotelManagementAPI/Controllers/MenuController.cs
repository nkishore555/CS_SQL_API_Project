using Application.Interfaces;
using HotelManagementAPI.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IMenuServices _menuServices;

        public MenuController(ILogger<MenuController> logger, IMenuServices menuServices)
        {
            _logger = logger;
            _menuServices = menuServices;
        }

        [HttpGet]
        public async Task<List<Application.Interfaces.MenuDetailsResponse>> GetMenuDetails()
        {
            _logger.LogInformation("Fetching menu details...");
            var result =  _menuServices.GetMenuItems();
            return result;
        }
    }
}
