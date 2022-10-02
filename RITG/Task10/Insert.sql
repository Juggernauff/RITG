INSERT INTO [Users] ([Login], [Password], [Age], [LastLogin])
VALUES
	('Login1', 'Password1', 16, 01/01/2021),
	('Login2', 'Password2', 17, 02/02/2021),
	('Login3', 'Password3', 18, 03/01/2021),
	('Login4', 'Password4', 19, 07/04/2021),
	('Login5', 'Password5', 14, 04/07/2021)

INSERT INTO [Profile] ([UserId], [FIO])
VALUES
	(8, 'FIO1'),
	(9, 'FIO2'),
	(10, 'FIO3'),
	(11, 'FIO4'),
	(12, 'FIO5')

INSERT INTO [TmpProfile] ([Login], [FirmId])
VALUES
	('Login1', 1),
	('Login2', 3),
	('Login3', 2),
	('Login4', 1)