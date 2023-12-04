using Microsoft.AspNetCore.Mvc;
using LibrarayManagementSystem.Data.Interfaces;

namespace LibrarayManagementSystem.Controllers;

public class UserRoleController : Controller
{
    private readonly IUserRoleRepository _userRoleRepository;
    private readonly ILogger<UserRoleController> _logger;
    public UserRoleController(IUserRoleRepository userRoleRepository, ILogger<UserRoleController> logger)
    {
        _userRoleRepository = userRoleRepository;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var data = _userRoleRepository.GetAll();
        _logger.LogInformation("Loading User Role Controller Index View");
        return data is not null ? View(data) : View(null);
    }
}
