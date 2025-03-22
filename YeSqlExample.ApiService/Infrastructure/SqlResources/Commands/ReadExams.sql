--Each SQL statement must be associated with a tag using the name: prefix and must begin with a comment. This is necessary so that the parser can uniquely identify each SQL statement by its tag.

--For example, in this case the tag is GetUsers and the SQL statement would be SELECT id, email FROM users;.

--You should also note that comments that do not use the name: prefix will be ignored by the parser.

-- name: GetUsers
-- Gets all users
SELECT 
id, 
email 
FROM users;

-- name: GetUserById
-- Gets user information
SELECT 
id, 
username, 
email 
FROM users
WHERE id = @id;

-- name: InsertUser
-- Create user record
INSERT INTO users (id, username, email)
VALUES (@id, @username, @email);