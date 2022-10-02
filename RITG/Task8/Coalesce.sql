SELECT U.Id, COALESCE(U.LastLogin, 'Never') AS 'LastLogin'
FROM [Users] U

SELECT P.Id, COALESCE(P.FIO, 'NoName') AS 'FullName'
FROM [Profile] P

SELECT COALESCE ((SELECT COUNT(*)
FROM [Profile] P
WHERE P.UserId IN (SELECT U.Id FROM Users U)), 0) AS 'Number of users with a profile'