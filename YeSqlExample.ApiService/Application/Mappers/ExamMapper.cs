using YeSqlExample.ApiService.Domain;
using YeSqlExample.Shared;

namespace YeSqlExample.ApiService.Application.Mappers;

public static class ExamMapper
{
    public static ExamDto ToExamDto(this Exam exam)
    {
        return new ExamDto(exam.ExamName, exam.MaxMark);
    }

    public static Exam ToExam(this ExamDto examDto)
    {
        return new Exam
        {
            ExamName = examDto.ExamName,
            MaxMark = examDto.MaxMark
        };
    }
}
