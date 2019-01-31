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
	@id nvarchar(320)
AS
	SELECT * from dbo.MemberInfo where ID = @id;
RETURN 0

Go

--비밀번호 수정 update  프로시저
CREATE PROCEDURE [dbo].UpdatePassWord
	@id NVARCHAR(320),
	@pw VARBINARY(500)
AS
	update AccountInfo set Password = @pw where ID = @id;
RETURN 0