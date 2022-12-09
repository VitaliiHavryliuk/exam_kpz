using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace exam_kpz.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public DateOnly Date { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
