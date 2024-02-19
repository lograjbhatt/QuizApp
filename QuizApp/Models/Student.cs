namespace QuizApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string? FullAddress { get; set; }
        public bool IsDeleted { get; set; }
    }
}
