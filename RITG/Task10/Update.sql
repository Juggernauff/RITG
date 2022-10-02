UPDATE [Users]
SET [Age] = [Age] + 1
WHERE [Age] = 19

UPDATE [Users]
SET [LastLogin] = GETDATE()
WHERE [Id] = 12