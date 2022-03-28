using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace project2.Models
{
    public class TimeSlot
    {
        [Key]
        public int TimeSlotID { get; set; }
        [Required]
        public string AppointmentTime { get; set; }
        public bool IsTaken { get; set; }
        
    }
}
