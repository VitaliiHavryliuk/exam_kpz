namespace Domain.Entities
{
    public  class Patient : BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string OwnerFullName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string Diagnosis { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
