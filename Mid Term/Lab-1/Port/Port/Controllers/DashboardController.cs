using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Port.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Port.Controllers
{
    public class DashboardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Home()
        {
            string name   = "Mahfuzur Rahman Ferdous";
            string email  = "mahfuzurferdous@gmail.com";
            string bio    = "Bohemian";
            ViewBag.Name  = name;
            ViewBag.Email = email;
            ViewBag.Bio   = bio;

            return View();
        }

        public IActionResult Profile()
        {
            PortModel p1 = new PortModel();
           
            p1.Name = "Mahfuzur Rahman Ferdous";
            p1.Dob = "17-Sep-2001";
            p1.Nation = "Bangladeshi";
            p1.BloodGroup = "A+";
            p1.Address = "Gazipur";
            p1.Contact = "01622898693";
            
            string[] hobbies = new string[] { "Travelling", "Hiking", "Gaming", "Sketching", "Outing", "Sleeping" };
            ViewBag.Hobbies = hobbies;


            return View(p1);
        }

        public IActionResult Education()
        {

                EduModel e1 = new EduModel();
                e1.Degree = "BSc";
                e1.Year = "2023";
                e1.Ins = "American International University-Bangladesh";

                EduModel e2 = new EduModel();
                e2.Year = "2019";
                e2.Degree = "HSC";
                e2.Ins = "Milestone College";

                EduModel e3 = new EduModel();
                e3.Year = "2017";
                e3.Degree = "SSC";
                e3.Ins = "Rani Bilashmoni Govt. Boys High School";

                EduModel[] eduModel = new EduModel[] { e1, e2, e3 };

                ViewBag.Edu = eduModel;
                return View();
            }

        public IActionResult Project()
        {
            var p1 = new ProjectModel();
            p1.Course = "CN";
            p1.Description = "COMPUTER NETWORKS";

            var p2 = new ProjectModel();
            p2.Course = ".ECL";
            p2.Description = "ELECTRONIC CIRCUIT";

            var p3 = new ProjectModel();
            p3.Course = ".Net";
            p3.Description = "ADVANCED PROGRAMMING WITH .NET";

            var projects = new ProjectModel[] { p1, p2, p3 };
            return View(projects);
        }
        public IActionResult Reference()
        {
            RefModel r1 = new RefModel();
            r1.Name = "Tanvir Ahmed";
            r1.Qualifications = " Msc. CS";
            r1.AreasOfExpertise = "Lcturer, Faculty, Computer Science";

            RefModel[] refModel = new RefModel[] { r1 };

            ViewBag.Ref = refModel;

            return View();
        }
    }
}

