using Microsoft.AspNetCore.Mvc;
using LibrarayManagementSystem.Data.Interfaces;

namespace LibrarayManagementSystem.Controllers;

public class StaffController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly ILogger<UserRoleController> _logger;
    public StaffController(IUserRepository userRepository, ILogger<UserRoleController> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var data = _userRepository.GetAll();
        _logger.LogInformation("Loading Staff Controller Index View");
        return data is not null ? View(data) : View(null);
    }
}
