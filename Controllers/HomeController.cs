using DependecyInjectionExample.IPerson;
using DependecyInjectionExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonSingleton _personSingletonOne;
        private readonly IPersonSingleton _personSingletonTwo;
        private readonly IPersonScoped _personScopedOne;
        private readonly IPersonScoped _personScopedTwo;
        private readonly IPersonTransient _personTransientOne;
        private readonly IPersonTransient _personTransientTwo;

        public HomeController(IPersonSingleton personSingletonOne, IPersonSingleton personSingletonTwo, 
            IPersonScoped personScopedOne, IPersonScoped personScopedTwo,
            IPersonTransient personTransientOne, IPersonTransient personTransientTwo)
        {
            _personSingletonOne = personSingletonOne;
            _personSingletonTwo = personSingletonTwo;
            _personScopedOne = personScopedOne;
            _personScopedTwo = personScopedTwo;
            _personTransientOne = personTransientOne;
            _personTransientTwo = personTransientTwo;
        }

        public IActionResult Index()
        {
            ViewData["PersonSingletonOne"] = _personSingletonOne.ID;
            ViewData["PersonSingletonTwo"] = _personSingletonTwo.ID;
            ViewData["PersonScopedOne"] = _personScopedOne.ID;
            ViewData["PersonScopedTwo"] = _personScopedTwo.ID;
            ViewData["PersonTransientOne"] = _personTransientOne.ID;
            ViewData["PersonTransientTwo"] = _personTransientTwo.ID;

            return View();
        }

    }
}
