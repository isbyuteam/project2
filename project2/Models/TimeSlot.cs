using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace project2.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotID { get; set; }
        [Required]
        public string AppointmentTime { get; set; }
    }
}
