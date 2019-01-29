--로그인프로시저
CREATE PROCEDURE [dbo].AccountLogin
	@id NVARCHAR (320),
	@pw nvarchar (500)  
AS
	SELECT * from dbo.AccountInfo where ID = @id and Password = hashbytes('md5', @pw);
RETURN 0

Go

--멤버인포 select 프로시저
CREATE PROCEDURE [dbo].SelectMember
AS
	SELECT * from dbo.MemberInfo;
RETURN 0

Go