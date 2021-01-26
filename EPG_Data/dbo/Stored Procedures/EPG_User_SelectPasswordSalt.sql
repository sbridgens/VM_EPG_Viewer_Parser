CREATE PROCEDURE [dbo].[EPG_User_SelectPasswordSalt]
	@Username nvarchar(50)
AS
	SELECT U.[Ud_PasswordSalt]
	FROM [UserData]  U WITH (NOLOCK) 
	WHERE U.[Ud_Username] = @Username
RETURN 0
