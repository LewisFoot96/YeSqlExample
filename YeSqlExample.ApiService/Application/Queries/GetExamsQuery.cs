using MediatR;
using YeSqlExample.Shared;

namespace YeSqlExample.ApiService.Application.Queries;

public record GetExamsQuery : IRequest<List<ExamDto>>;
