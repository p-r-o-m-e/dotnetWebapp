using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

namespace dotnetLearning.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int id = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = id;
        return View();
    }
}
//using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

//namespace dotnetLearning.Controllers;

//public class HelloWorldController : Controller
//{
//    // 
//    // GET: /HelloWorld/
//    public IActionResult Index()
//    {
//        return View();
//    }
//    // 
//    // GET: /HelloWorld/Welcome/ 
//    public string Welcome(String name = "", int id = 1)
//    {
//        return HtmlEncoder.Default.Encode($"Hello {name}, ID is {id}.");
//    }
//}