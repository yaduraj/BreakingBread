CREATE PROCEDURE prc_AddUser(
  @userId NVARCHAR(256),
  @name NVARCHAR(256),
  @mobile BIGINT)    
AS
BEGIN
SET NOCOUNT ON 

DECLARE @status INT

BEGIN TRANSACTION

INSERT tbl_User
       (
            UserId,
			Name,
			Mobile
        )
    VALUES
        (
            @userId,
            @name,
            @mobile
        )

    SELECT  @status = @@ERROR
    IF (@status <> 0)
    BEGIN
        ROLLBACK TRAN
        RETURN -1
    END

COMMIT TRANSACTION

RETURN 0
END
