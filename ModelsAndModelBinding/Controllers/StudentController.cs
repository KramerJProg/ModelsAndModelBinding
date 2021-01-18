using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
