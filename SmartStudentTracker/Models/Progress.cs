namespace SmartStudentTracker.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
