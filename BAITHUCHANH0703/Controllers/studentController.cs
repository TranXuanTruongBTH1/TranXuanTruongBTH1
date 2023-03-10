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
        //Chuyen đoi kieu du lieu
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
        //giải phương trình b2
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
                    //nếu b = 0 và c = 0 thì phương trình vô số nghiệm
                    if (c == 0)
                    {
                        thongBao = " Phuong trinh  vo so   nghiem.";
                    }
                    //nếu b = 0 và c != 0 thì phương trình vô nghiệm
                    else
                    {
                        thongBao = "Phuong trinh  vo  nghiem.";
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                    thongBao = "Phuong trinh co nghiem duy nhat x = {0}" + (Math.Round(x1, 2));
                }
            
            }
            //nếu a != 0 thì ta bắt đầu giải phương trình bậc hai
            else
            {
                //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //kiểm tra nếu delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    thongBao = "Phuong trinh vo nghiem.";
                }
                //nếu delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    thongBao = "\n Phuong trinh co nghiem kep x1 = x2 = {0}" + x1;
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
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
        //xay dung cac phuong thuc
        public string GiaiPhuongTrinhBacNhat(double a, double b)
        {
            //khai bao 1 bien  de chua du lieu
            string thongBao = "";
            //khai bao 1 bien so de chua gia tri
            double x;
            //Giai phuong trinh
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
                //tinh nghiem cua phuong trinh
                x = -b / a;
                thongBao = " nghiem kep x= " + x;
            }
            //tra ve du lieu
            return thongBao;
        }
    }

    
    

