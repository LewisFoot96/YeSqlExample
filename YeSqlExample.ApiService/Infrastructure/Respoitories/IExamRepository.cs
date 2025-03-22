using YeSqlExample.ApiService.Domain;

namespace YeSqlExample.ApiService.Infrastructure.Respoitories;

public interface IExamRepository
{
    Task<List<Exam>> GetAllExams();
}
