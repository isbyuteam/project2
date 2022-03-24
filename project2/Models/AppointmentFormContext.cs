using System;
using Microsoft.EntityFrameworkCore;

namespace project2.Models
{
    public class AppointmentFormContext : DbContext
    {
        public AppointmentFormContext(DbContextOptions<AppointmentFormContext> options) : base(options) {}

        public DbSet<AppointmentForm> Responses { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { TimeSlotID = 1, AppointmentTime = "8:00 AM", IsTaken = false },
                new TimeSlot { TimeSlotID = 2, AppointmentTime = "9:00 AM", IsTaken = false },
                new TimeSlot { TimeSlotID = 3, AppointmentTime = "10:00 AM", IsTaken = false },
                new TimeSlot { TimeSlotID = 4, AppointmentTime = "11:00 AM", IsTaken = false },
                new TimeSlot { TimeSlotID = 5, AppointmentTime = "12:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 6, AppointmentTime = "1:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 7, AppointmentTime = "2:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 8, AppointmentTime = "3:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 9, AppointmentTime = "4:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 10, AppointmentTime = "5:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 11, AppointmentTime = "6:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 12, AppointmentTime = "7:00 PM", IsTaken = false },
                new TimeSlot { TimeSlotID = 13, AppointmentTime = "8:00 PM", IsTaken = false }
            );

            mb.Entity<AppointmentForm>().HasData(
                new AppointmentForm
                {
                    AppointmentID = 1,
                    GroupName = "Kylie",
                    GroupSize = 5,
                    Email = "kyliefromm@gmail.com",
                    Phone = "801-555-5555",
                    TimeSlotID = 8
                }
            );
        }
    }
}