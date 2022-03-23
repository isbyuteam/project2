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
                new TimeSlot { TimeSlotID = 8, AppointmentTime = "8:00" },
                new TimeSlot { TimeSlotID = 9, AppointmentTime = "9:00" },
                new TimeSlot { TimeSlotID = 10, AppointmentTime = "10:00" },
                new TimeSlot { TimeSlotID = 11, AppointmentTime = "11:00" },
                new TimeSlot { TimeSlotID = 12, AppointmentTime = "12:00" },
                new TimeSlot { TimeSlotID = 13, AppointmentTime = "1:00" },
                new TimeSlot { TimeSlotID = 14, AppointmentTime = "2:00" },
                new TimeSlot { TimeSlotID = 15, AppointmentTime = "3:00" },
                new TimeSlot { TimeSlotID = 16, AppointmentTime = "4:00" },
                new TimeSlot { TimeSlotID = 17, AppointmentTime = "5:00" },
                new TimeSlot { TimeSlotID = 18, AppointmentTime = "6:00" },
                new TimeSlot { TimeSlotID = 19, AppointmentTime = "7:00" },
                new TimeSlot { TimeSlotID = 20, AppointmentTime = "8:00" }
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