using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using project2.Models;
using project2.Models.ViewModels;

namespace project2.Controllers
{
    public class HomeController : Controller
    {

        private AppointmentFormContext FormContext { get; set; }


        public HomeController(AppointmentFormContext x)
        {
            FormContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SignUp()
        {

            // get all times from the database and pass them as a parameter in view
            var appointments = FormContext.TimeSlots
                .Where(x => x.IsTaken == false)
                .ToList();
            return View(appointments);
        }

        [HttpGet]
        public IActionResult AppointmentForm()
        {
            ViewBag.TimeSlots = FormContext.TimeSlots.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult AppointmentForm(int timeslotid)
        {
            var x = new AppointmentViewModel
            {
                //BUG HERE NOT WORKING> NEED TO FIX
                //apt = FormContext.TimeSlots.FirstOrDefault(x => x.TimeSlotID == timeslotid),

                times = new TimeSlot()
            };

            return View(x);
        }

        [HttpPost]
        public IActionResult AppointmentForm(AppointmentForm ar)
        {
            if (ModelState.IsValid)
            {
                //BUG NOT WORKING  NEED TO FIX VIEW MODELS
                //FormContext.TimeSlots.Single(x => x.TimeSlotID == ar.timeslot.TimeSlots.TimeSlotID).Booked = true;
                //FormContext.Add(ar.timeslot);
                FormContext.SaveChanges();
                return View("Index");
            }
            else
            {
                ViewBag.TimeSlots = FormContext.TimeSlots.ToList();
                return View();
            }
        }

        //public IActionResult AppointmentList()
        //{
        //    var appointments = FormContext.Responses.Include(x => x.GroupName)
        //        .OrderBy(x => x.GroupName)
        //        .ToList();

        //    return View(appointments);


        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
