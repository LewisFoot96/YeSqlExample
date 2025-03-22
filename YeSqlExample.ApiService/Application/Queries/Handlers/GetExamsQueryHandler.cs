using MediatR;
using YeSqlExample.ApiService.Application.Mappers;
using YeSqlExample.Shared;
using YeSqlExample.ApiService.Infrastructure.Respoitories;

namespace YeSqlExample.ApiService.Application.Queries.Handlers;

public class GetExamsQueryHander(IExamRepository repository) : IRequestHandler<GetExamsQuery, List<ExamDto>>
{
    public async Task<List<ExamDto>> Handle(GetExamsQuery request, CancellationToken cancellationToken)
    {
        string test = "";
        var examResult = await repository.GetAllExams();

        return examResult.Select(exam => exam?.ToExamDto()).ToList()!;
    }
}
