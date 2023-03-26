using System.Collections.Specialized;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2002.Models;

namespace BaiThucHanh2002.Controllers;

public class PersonController : Controller
{
    public IActionResult About()
    {
        
        return View();
    }
[HttpPost]
    public IActionResult About(Person std)
    {
        string kq= std.MaCongDan +"_" + std.TenCongDan + "_" +std.ChucVu;
        
        return View();
    }
}
