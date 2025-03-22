using Dapper;
using Microsoft.Data.SqlClient;
using YeSql.Net;
using YeSqlExample.ApiService.Domain;
using YeSqlExample.ApiService.Infrastructure.SqlResources.Query;

namespace YeSqlExample.ApiService.Infrastructure.Respoitories;

public class ExamRepository : IExamRepository
{
    private readonly ISqlCollection _sqlCollection;
    public SqlConnection _sqlClient;

    public ExamRepository(ISqlCollection sqlCollection, SqlConnection sql)
    {
        _sqlCollection = sqlCollection;
        _sqlClient = sql;
    }
    public async Task<List<Exam>> GetAllExams()
    {
        var exams = new List<Exam>();
        string sql = _sqlCollection[QueryConstants.GetExams];

        try
        {
            await _sqlClient.OpenAsync();
            exams = _sqlClient.Query<Exam>(sql).ToList();
            await _sqlClient.CloseAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Validating some sql from a string
        var source =
                    """
                    -- name: GetExamsNew
                    -- Get exams from the database
                    SELECTbnfgn 
                    ExamName, 
                    MaxMark
                    FROMfds Exams;
                    """;
        YeSqlValidationResult validationResult;
        ISqlCollection sqlStatements = new YeSqlParser().Parse(source, out validationResult);
        if (validationResult.HasError())
        {
            // Some code to handle the error.
        }

        return exams;
    }
}
