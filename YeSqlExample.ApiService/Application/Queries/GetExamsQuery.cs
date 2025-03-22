using MediatR;
using YeSqlExample.ApiService.DTOs;

namespace YeSqlExample.ApiService.Application.Queries;

public record GetExamsQuery : IRequest<List<ExamDto>>;
