using YeSqlExample.Shared;

namespace YeSqlExample.Web;

public class ExamApiClient(HttpClient httpClient)
{
    public async Task<ExamDto[]> GetExamsAsync(int maxItems = 10, CancellationToken cancellationToken = default)
    {
        List<ExamDto>? exams = null;

        await foreach (var exam in httpClient.GetFromJsonAsAsyncEnumerable<ExamDto>("/exam", cancellationToken))
        {
            if (exams?.Count >= maxItems)
            {
                break;
            }
            if (exam is not null)
            {
                exams ??= [];
                exams.Add(exam);
            }
        }

        return exams?.ToArray() ?? [];
    }
}

