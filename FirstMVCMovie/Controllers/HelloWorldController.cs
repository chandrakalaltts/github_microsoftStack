using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace FirstMVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
             return View();
            //return "This is my first default Action..";
        }
        public IActionResult Welcome(string name,int numTimes=1)
        {
            //return "This is my First Welcome Action..";
            //  return HtmlEncoder.Default.Encode($"Hello {name} , the number of Times is : {numTimes}");
            ViewData["Message"] = "Hello" +name;
            ViewData["NumTimes"] = numTimes;
            return View();

        }
    }
}
