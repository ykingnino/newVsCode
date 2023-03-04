using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ybanez.Models;

namespace Ybanez.Controllers;

public class HelloWorld : Controller
{
    
    public IActionResult Hello()
    {
        return View();
    }


   
}
