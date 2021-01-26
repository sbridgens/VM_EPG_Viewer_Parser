CREATE PROCEDURE [dbo].[EPG_User_Register]
	@Firstname nvarchar(100), 
	@Lastname nvarchar(100), 
	@Email nvarchar(250),
	@Username nvarchar(100), 
	@Password varchar(max), 
	@PasswordSalt varchar(max),
	@IsActive BIT,
	@CreatedOn DATETIME
AS
	DECLARE @Id bigint
	IF NOT EXISTS(SELECT [Id] FROM [UserData] WHERE [Ud_Username] = @Username OR [Ud_Email] = @Email)
	BEGIN
		INSERT INTO [UserData] ([Ud_Firstname], [Ud_Lastname], [Ud_Email], [Ud_Username], [Ud_Password], [Ud_PasswordSalt], [Ud_IsActive], [Ud_CreatedOn]) 
		VALUES (@Firstname, @Lastname, @Email, @Username, @Password, @PasswordSalt, @IsActive, @CreatedOn)
		SET @Id = SCOPE_IDENTITY();
	END
	ELSE
		SET @Id = 0;
	
	SELECT @Id;
RETURN 0
