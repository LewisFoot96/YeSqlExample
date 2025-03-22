using MediatR;
using YeSqlExample.ApiService.Application.Queries;

namespace YeSqlExample.ApiService.Endpoints;

public static class ExamEndpoints
{
    public static void MapExamEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("exam");
        //Minimal apis use method injection

        group.MapGet("/", GetExams);
    }

    private static async Task<IResult> GetExams(IMediator sender)
    {
        var result = await sender.Send(new GetExamsQuery());

        return
            TypedResults.Ok(result);

    }
}