using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public AppointmentForm apt { get; set; }
        public TimeSlot times { get; set; }
    }
}