--로그인프로시저
CREATE PROCEDURE [dbo].AccountLogin
	@id NVARCHAR (320),
	@pw nvarchar (500)  
AS
	SELECT * from dbo.AccountInfo where ID = @id and Password = hashbytes('md5', @pw);
RETURN 0

Go

--멤버인포 select 프로시저
<<<<<<< HEAD
--CREATE PROCEDURE [dbo].SelectMember

--AS
--	SELECT * from dbo.MemberInfo;

--	@id nvarchar(320)
--AS
--	SELECT * from dbo.MemberInfo where ID = @id;

--RETURN 0
=======
CREATE PROCEDURE [dbo].SelectMember
	@id nvarchar(320)
AS
	SELECT * from dbo.MemberInfo where ID = @id;
RETURN 0
>>>>>>> 0abd41c8e3530463e0c9361d9844163cb3b2d6b4

Go

--비밀번호 수정 update  프로시저
CREATE PROCEDURE [dbo].UpdatePassWord
	@id NVARCHAR(320),
	@pw VARBINARY(500)
AS
	update AccountInfo set Password = hashbytes('md5', @pw) where ID = @id;
RETURN 0