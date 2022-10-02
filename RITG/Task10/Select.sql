SELECT *
FROM [Users] U
WHERE EXISTS(SELECT [UserId] FROM [Profile] P WHERE U.Id = P.UserId)

SELECT [FIO] 
FROM [Profile]

SELECT [FirmId], COUNT([Login]) AS 'Number records'
FROM [TmpProfile]
GROUP BY [FirmId]