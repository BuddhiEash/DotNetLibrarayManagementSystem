using Microsoft.AspNetCore.Mvc;
using LibrarayManagementSystem.Data.Interfaces;

namespace LibrarayManagementSystem.Controllers;

public class UserController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly ILogger<UserRoleController> _logger;
    public UserController(IUserRepository userRepository, ILogger<UserRoleController> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var users = _userRepository.GetAll();
        ViewData["roles"] = null;
        _logger.LogInformation("Loading User Controller Index View");
        if (users is not null) 
        {
            _logger.LogInformation($"User roles are not null");
            ViewData["users"] = users;
        }
        return View();
    }
}
