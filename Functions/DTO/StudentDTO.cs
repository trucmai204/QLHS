namespace Functions.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Gender { get; set; }
        public string ClassName { get; set; }
        public int Grade { get; set; }
        public string? SchoolYear { get; set; }
    }
}
