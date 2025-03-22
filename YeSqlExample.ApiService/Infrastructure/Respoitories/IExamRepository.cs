namespace YeSqlExample.ApiService.Infrastructure.Respoitories;

public interface IExamRepository
{
    Task<List<Exam>> GetAllExams();
}
