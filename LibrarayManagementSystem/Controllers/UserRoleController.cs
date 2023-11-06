using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibrarayManagementSystem.Models;
using LibrarayManagementSystem.Data;

namespace LibrarayManagementSystem.Controllers;

public class UserRoleController : Controller
{
    private readonly AppDbContext _appDbContext;
    public UserRoleController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
