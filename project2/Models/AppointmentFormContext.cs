using System;
using Microsoft.EntityFrameworkCore;

namespace project2.Models
{
    public class AppointmentFormContext : DbContext
    {
        public AppointmentFormContext(DbContextOptions<AppointmentFormContext> options) : base(options) {}

        public DbSet<AppointmentForm> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AppointmentForm>().HasData(
                new AppointmentForm
                {
                    AppointmentID = 1,
                    GroupName = "Kylie",
                    GroupSize = 5,
                    Email = "kyliefromm@gmail.com",
                    Phone = "801-555-5555",
                }
            );
        }
    }
}