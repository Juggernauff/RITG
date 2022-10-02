SELECT *
FROM [Users] U
WHERE EXISTS(SELECT [UserId]
			FROM [Profile] P
			WHERE U.Id = P.UserId)

SELECT *
FROM [Users] U
WHERE EXISTS(SELECT *
			FROM [TmpProfile] TP
			WHERE U.Login = TP.Login)

SELECT [FIO]
FROM [Profile] P
WHERE EXISTS(SELECT *
			FROM [Users] U
			WHERE EXISTS(SELECT *
						FROM [TmpProfile] TP
						WHERE TP.Login = U.Login AND U.Id = P.UserId))