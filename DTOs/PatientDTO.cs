namespace DTOs
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string OwnerFullName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string Diagnosis { get; set; }
    }
}
