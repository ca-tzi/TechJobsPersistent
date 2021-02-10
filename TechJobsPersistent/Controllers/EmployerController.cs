using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using TechJobsPersistent.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {

        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }




        // GET: /<controller>/
        [HttpGet("/addemployer")]
        
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            ViewBag.employers = employers;
            
            return View(employers);
        }
        [HttpPost]
        public IActionResult Add()
        {


            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();

            return View(addEmployerViewModel);
        }
        [HttpPost]
        
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {

                Employer employer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location


                };

                context.Employers.Add(employer);
                context.SaveChanges();
                return Redirect("../home/addjob");

            }
            return View("../home/addjob", addEmployerViewModel);
        }

        public IActionResult About(int id)
        {
            List<Employer> employers = context.Employers.ToList();

            ViewBag.employers = employers;


            return View();
        }

        
    }
}
