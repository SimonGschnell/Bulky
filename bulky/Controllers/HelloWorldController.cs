using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bulky.Models;
using System.Text.Encodings.Web;

namespace bulky.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public IActionResult Index(){
        return View();
    }

    // GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int id, int numTimes){
        ViewData["Message"] = $"Hello {name}";
        ViewData["ID"]=id;
        ViewData["NumTimes"]=numTimes;
        return View();
    }
}