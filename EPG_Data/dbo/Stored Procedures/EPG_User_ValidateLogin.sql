CREATE PROCEDURE [dbo].[EPG_User_ValidateLogin]
	@Username nvarchar(250), 
	@Password varchar(max)
AS
	
	SELECT	U.[Id], U.[Ud_Firstname] as Uid_Firstname, U.[Ud_Lastname] as Uid_Lastname, U.[Ud_Email] as Uid_Email, U.[Ud_Username] as Uid_Username, U.[Ud_IsActive] as Uid_IsActive
	FROM	[UserData]  U WITH (NOLOCK)
	WHERE	(U.[Ud_Email] = @Username OR U.[Ud_Username] = @Username)
		AND U.[Ud_Password] = @Password
		AND U.[Ud_IsActive] = 1

RETURN 0
