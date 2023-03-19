using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BAITHUCHANH0703.Models;

namespace BAITHUCHANH0703.Controllers;

public class studentController : Controller
{
public IActionResult Index()
    {
        return View();
    }
   [HttpPost]
    public IActionResult Index(string FullName)
    {
        string strReturn = "Hello" + " " + FullName;
        ViewBag.abc = strReturn;
        return View();
    }

     public IActionResult Create()
    {
        return View();
    }
    public IActionResult Tinhtong()
    {
        return View();
    }
     [HttpPost]
    public IActionResult Tinhtong(string Number)
    {
        int so = Convert.ToInt32(Number);
        int tong = 0;
        while(so >0)
        {
            tong = tong + so%10;
            so = so/10;
        }
        ViewBag.message = "ket qua = " + tong;
        return View();
    }
    public IActionResult giaiphuongtrinhbac2()
    {
        return View();
    }
 [HttpPost]
        public string giaiphuongtrinhbac2(double a, double b, double c)
        {
            string thongBao = "";
            double x1;
            double x2;
            double delta;
            if (a == 0)
            {
                thongBao = GiaiPhuongTrinhBacNhat(b, c);
                if (b == 0)
                {
                    if (c == 0)
                    {
                        thongBao = " Phuong trinh  vo so   nghiem.";
                    }
                    else
                    {
                        thongBao = "Phuong trinh  vo  nghiem.";
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    thongBao = "Phuong trinh co nghiem duy nhat x = {0}" + (Math.Round(x1, 2));
                }
            
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    thongBao = "Phuong trinh vo nghiem.";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    thongBao = "\n Phuong trinh co nghiem kep x1 = x2 = {0}" + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    thongBao =
                    "Phương trình có nghiệm X1=" + x1 + "" + "và" + "" + "X2=" + x2;
                }
            }

            return thongBao;
        }
        public string GiaiPhuongTrinhBacNhat(double a, double b)
        {
            string thongBao = "";
            double x;
            if (a == 0)
            {
                if (b== 0)
                {
                    thongBao = "Phuong trinh co vo so nghiem.";
                }
                else
                {
                    thongBao = "Phuong trinh vo nghiem";
                }

            }
            else
            {
                x = -b / a;
                thongBao = " nghiem kep x= " + x;
            }
            return thongBao;
        }
    }

    
    

