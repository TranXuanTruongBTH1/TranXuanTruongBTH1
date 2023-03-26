using System.Collections.Specialized;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2002.Models;

namespace BaiThucHanh2002.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Create()
    {
        
        return View();
    }
[HttpPost]
    public IActionResult Create(Student std)
    {
        string ketqua = std.StudentCode +"_" + std.FullName + "_" +std.Address;
        ViewBag.message = ketqua;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

