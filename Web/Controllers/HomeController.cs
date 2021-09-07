using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitofwork<Owner> _owner;
        private readonly IUnitofwork<Portfolio> _portfolio;

        public HomeController(IUnitofwork<Owner> owner, IUnitofwork<Portfolio> portfolio)
        {
            _owner = owner;
            _portfolio = portfolio;
        }
        public IActionResult Index()
        {
            var homeviewmodel = new HomeViewModel
            {
                owner = _owner.entity.Getall().First(),
                portfolio= _portfolio.entity.Getall().ToList()
            };
            return View(homeviewmodel);
        }
    }
}
