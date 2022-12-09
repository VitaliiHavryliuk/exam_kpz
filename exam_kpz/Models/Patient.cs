using System.ComponentModel.DataAnnotations;

namespace exam_kpz.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }

        [MaxLength(100)]
        public string OwnerFullName { get; set; }

        public DateOnly DateOfBirth { get; set; }

        [MaxLength(200)]
        public string Diagnosis { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
