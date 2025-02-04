namespace SmartStudentTracker.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public List<Progress> ProgressRecords { get; set; } = new List<Progress>();
    }
}
