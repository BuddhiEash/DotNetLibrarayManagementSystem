using Microsoft.AspNetCore.Mvc;
using LibrarayManagementSystem.Data.Interfaces;

namespace LibrarayManagementSystem.Controllers;

public class UserRoleController : Controller
{
    private readonly IUserRolesRepository _userRolesRepository;
    private readonly ILogger<UserRoleController> _logger;
    public UserRoleController(IUserRolesRepository userRolesRepository, ILogger<UserRoleController> logger)
    {
        _userRolesRepository = userRolesRepository;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var customers = _userRolesRepository.GetAll();
        ViewData["roles"] = null;
        _logger.LogInformation("Loading User Controller Index View");
        if (customers is not null) 
        {
            _logger.LogInformation($"User roles are not null");
            ViewData["roles"] = customers;
        }
        return View();
    }
}
