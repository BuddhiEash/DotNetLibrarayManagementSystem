using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibrarayManagementSystem.Models;
using LibrarayManagementSystem.Data;

namespace LibrarayManagementSystem.Controllers;

public class UserRoleController : Controller
{
    private readonly AppDbContext _appDbContext;
    private readonly ILogger<UserRoleController> _logger;
    public UserRoleController(AppDbContext appDbContext, ILogger<UserRoleController> logger)
    {
        _appDbContext = appDbContext;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        _logger.LogInformation("Loading User Controller Index View");
        return View();
    }
}
