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
        var userRoles = GetRoles();
        ViewData["roles"] = null;
        _logger.LogInformation("Loading User Controller Index View");
        if (userRoles is not null) 
        {
            _logger.LogInformation($"User roles are not null");
            ViewData["roles"] = userRoles;
        }
        return View();
    }

    public List<UserRole>? GetRoles()
    {
        try
        {
            return _appDbContext.UserRoles.OrderBy(u => u.Id).Take(10).ToList();
        }
        catch (Exception ex)
        {
            _logger.LogInformation($"Failed to get the latest user:{ex}");
            return null;
        }
    }
}
