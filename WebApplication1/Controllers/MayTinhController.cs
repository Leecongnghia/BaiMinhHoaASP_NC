using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Minh họa 1: Tiếp nhận tham số thông qua Reques
        //public IActionResult XuLy()
        //{
        //    //b1.Lấy giá trị các tham số (So1, So2, phep tinh)
        //    var x = double.Parse(Request.Form["So1"]);
        //    var y = double.Parse(Request.Form["So2"]);
        //    var op = Request.Form["PhepTinh"];
        //    //b2. Tính toán kết quả
        //    double Ketqua = 0;
        //    switch (op)
        //    {
        //        case "+": Ketqua = x + y; break;
        //        case "-": Ketqua = x - y; break;
        //        case "*": Ketqua = x * y; break;
        //        case "/": Ketqua = x / y; break;
        //    }
        //    //b3.Trả kết quả về người dùng
        //    ViewData["KQ"] = Ketqua;
        //    ViewBag.KQ = Ketqua;
        //    return View("XuLy");
        //}

        //Minh họa 2: Tiếp nhận tham số thông qua đối số của action
        //public IActionResult XuLy(double So1, double So2, string PhepTinh)
        //{
        //    //b1.Lấy giá trị các tham số (So1, So2, phep tinh)
        //    //b2. Tính toán kết quả
        //    double Ketqua = 0;
        //    switch (PhepTinh)
        //    {
        //        case "+": Ketqua = So1 + So2; break;
        //        case "-": Ketqua = So1 - So2; break;
        //        case "*": Ketqua = So1 * So2; break;
        //        case "/": Ketqua = So1 / So2; break;
        //    }
        //    //b3.Trả kết quả về người dùng
        //    //ViewData["KQ"] = Ketqua;//Truyền dữ liệu cho view thông qua viewdata
        //    ViewBag.KQ = Ketqua;//Truyền dữ liệu cho view thông qua viewbag
        //    return View();
        //}

        //Minh họa 3: Tiếp nhận tham số thông qua Model
        public IActionResult XuLy(MayTinhModel mt)
        {
            //b1.Lấy giá trị các tham số (So1, So2, phep tinh)
            //b2. Tính toán kết quả
            double ketqua = 0;
            switch(mt.PhepTinh)
            {
                case "+": ketqua = mt.So1 + mt.So2; break;
                case "-": ketqua = mt.So1 - mt.So2; break;
                case "*": ketqua = mt.So1 * mt.So2; break;
                case "/": ketqua = mt.So1 / mt.So2; break;
            }
            //b3.Trả kết quả về người dùng
            //ViewData["KQ"] = Ketqua;//Truyền dữ liệu cho view thông qua viewdata
            ViewBag.KQ = mt.KetQua();//Truyền dữ liệu cho view thông qua viewbag
            return View("Index",mt);
        }
    }
}
