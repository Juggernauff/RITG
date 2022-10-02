SELECT *
FROM Users U1
JOIN Profile P
ON U1.Id = P.UserId
JOIN TmpProfile TP
ON U1.Login = TP.Login
WHERE U1.Age IN (
SELECT MAX(U.Age) AS 'MaxAge'
FROM Users U
JOIN TmpProfile TP
ON U.Login = TP.Login
GROUP BY TP.FirmId)