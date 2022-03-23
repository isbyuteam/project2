using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using project2.Models;

namespace project2.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentFormContext moneyContext { get; set; }

        public HomeController(AppointmentFormContext someName)
        {
            moneyContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult AppointmentsList()
        {
            var appointments = moneyContext.Responses
                .Include(x => x.TimeSlot)
                .OrderBy(x => x.TimeSlot.AppointmentTime)
                .ToList();

            return View(appointments);
        }

        [HttpGet]
        public IActionResult AppointmentForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AppointmentForm(AppointmentForm ar)
        {
            if (ModelState.IsValid)
            {
                //FormContext.Add(ar);
                //FormContext.SaveChanges();
                return Index();
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            ViewBag.TimeSlots = moneyContext.TimeSlots.ToList();

            var appointment = moneyContext.Responses.Single(x => x.AppointmentID == appointmentid);

            return View("AppointmentForm", appointment);
        }

        [HttpPost]
        public IActionResult Edit(AppointmentForm af)
        {
            moneyContext.Update(af);
            moneyContext.SaveChanges();

            return RedirectToAction("AppointmentsList");
        }

        [HttpGet]
        public IActionResult Delete(int appointmentid)
        {
            var appointment = moneyContext.Responses.Single(x => x.AppointmentID == appointmentid);

            return View(appointment);
        }

        [HttpPost]
        public IActionResult Delete(AppointmentForm af)
        {
            moneyContext.Responses.Remove(af);
            moneyContext.SaveChanges();

            return RedirectToAction("AppointmentsList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
