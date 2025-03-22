using YeSql.Net;
using YeSqlExample.ApiService.Domain;
using YeSqlExample.ApiService.Infrastructure.SqlResources.Query;

namespace YeSqlExample.ApiService.Infrastructure.Respoitories;

public class ExamRepository : IExamRepository
{
    private readonly ISqlCollection _sqlCollection;

    public ExamRepository(ISqlCollection sqlCollection)
    {
        _sqlCollection = sqlCollection;
    }
    public Task<List<Exam>> GetAllExams()
    {
        string sql = _sqlCollection[QueryConstants.GetExams];

        return Task.FromResult(new List<Exam>());
    }
}
