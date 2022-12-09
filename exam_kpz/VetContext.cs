using exam_kpz.Models;
using Microsoft.EntityFrameworkCore;

namespace exam_kpz
{
    public class VetContext:DbContext
    {
        public VetContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
