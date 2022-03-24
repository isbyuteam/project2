using System;
using System.ComponentModel.DataAnnotations;

namespace project2.Models
{
    public class AppointmentForm
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; }
        [Required(ErrorMessage = "Group name is Required")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Size of group is Required")]
        [Range(0, 15)]
        public int GroupSize { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public int TimeSlotID { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}