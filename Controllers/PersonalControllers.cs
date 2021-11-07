using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers;

public class PersonalController : Controller
{
    public IActionResult index()
    {
        Personal personal = new Personal(); 
        personal.name = "Daniel";
        personal.lastname = "Castillo";
        personal.age = 18;
        return View(personal);
    }



    
}