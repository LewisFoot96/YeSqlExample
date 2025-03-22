namespace YeSqlExample.ApiService.Domain;

public class Exam
{
    public int Id { get; set; }
    public required string ExamName { get; set; }
    public required int MaxMark { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
