SELECT *
FROM Users U
JOIN Profile P
ON U.Id = P.UserId
JOIN TmpProfile TP
ON U.Login = TP.Login
WHERE U.RoleID IN (SELECT R.Id
					FROM Roles R
					JOIN Firms F
					ON R.Id = F.RoleId)