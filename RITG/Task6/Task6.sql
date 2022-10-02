SELECT *
FROM Users U1
JOIN Profile P
ON U1.Id = P.UserId
JOIN TmpProfile TP
ON U1.Login = TP.Login
WHERE U1.Age IN (
SELECT MAX(U.Age)
FROM Users U
JOIN TmpProfile TP1
ON U.Login = TP1.Login
GROUP BY TP1.FirmId
HAVING TP1.FirmId = TP.FirmId)