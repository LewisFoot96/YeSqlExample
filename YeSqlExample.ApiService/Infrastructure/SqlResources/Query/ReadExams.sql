--Each SQL statement must be associated with a tag using the name: prefix and must begin with a comment. This is necessary so that the parser can uniquely identify each SQL statement by its tag.

--For example, in this case the tag is GetUsers and the SQL statement would be SELECT id, email FROM users;.

--You should also note that comments that do not use the name: prefix will be ignored by the parser.

-- name: GetExams
-- Gets all exams
SELECT 
Id, 
ExamName 
FROM Exams;

-- name: GetExamById
-- Gets user information
SELECT 
Id, 
ExamName 
FROM Exams
WHERE Id = @id;
