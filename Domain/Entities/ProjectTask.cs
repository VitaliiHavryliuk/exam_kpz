namespace Domain.Entities
{
    public class Appointment : BaseModel
    {
        public DateOnly? Date { get; set; }
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
