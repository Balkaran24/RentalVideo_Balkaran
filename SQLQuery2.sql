USE [master]
GO
/****** Object:  Database [RentalVideo_Balkaran]    Script Date: 14-06-2020 09:24:00 PM ******/
CREATE DATABASE [RentalVideo_Balkaran]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentalVideo_Balkaran', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentalVideo_Balkaran.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RentalVideo_Balkaran_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentalVideo_Balkaran_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RentalVideo_Balkaran] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentalVideo_Balkaran].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentalVideo_Balkaran] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET  MULTI_USER 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentalVideo_Balkaran] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RentalVideo_Balkaran] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RentalVideo_Balkaran]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoginID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
	[ReleaseDate] [date] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MoviesIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_Movies]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_Movies] AS
Select [MovieID]
      ,[Title]
      ,[Rating]
      ,[Year]
	  ,Genre
	  ,Plot
      ,[Rental_Cost] from Movies


GO
/****** Object:  StoredProcedure [dbo].[GetMoviesRentalList]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMoviesRentalList]
(
@rentalType char(1)
)
AS
BEGIN
IF(@rentalType='A')
BEGIN
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID 
END
else
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID where DateReturned is  null
END


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCustomers]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteCustomers]
@customerID int
AS
BEGIN

delete from Customer where CustID=@customerID

END


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteMovies]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteMovies]
@movieID int
AS
BEGIN

delete from Movies where MovieID=@movieID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerList]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCustomerList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	SELECT [CustID]
      ,[FirstName]
      ,[LastName]
      ,[Address]
      ,[Phone]
  FROM [dbo].[Customer]
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetMovieList]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetMovieList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT [MovieID]
      ,[Title]
	  ,[Genre]
      ,[Rental_Cost]
      ,Plot
  FROM [dbo].[Movies]
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetRentalList]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_GetRentalList]
AS
BEGIN

SelecT RentedMovies.RMID, FirstName, LastName, Address,Phone, Title,Genre Rental_Cost,Plot, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID


END



GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRentalIssueMovie]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertRentalIssueMovie]
(
@customerID int,
@movieID int
)
AS

BEGIN


INSERT INTO [dbo].[RentedMovies]
           ([MoviesIDFK]
           ,[CustIDFK]
           ,[DateRented]
           )
     VALUES
           (@movieID
           ,@customerID
           ,GETDATE()
           )
END


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateCustomer]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUpdateCustomer]
@FirstName nvarchar(255)
,@LastName nvarchar(255)
,@Address nvarchar(255)
,@Phone nvarchar(255)
,@CustID int=0
AS
BEGIN
IF(@CustID >0)
BEGIN
UPDATE [dbo].[Customer]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Address] = @Address
      ,[Phone] = @Phone
 WHERE CustID = @CustID
END
ELSE
BEGIN
INSERT INTO [dbo].[Customer]
           ([FirstName]
           ,[LastName]
           ,[Address]
           ,[Phone])
     VALUES
           (@FirstName
           ,@LastName
           ,@Address
           ,@Phone)

END


END


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateMovies]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUpdateMovies]
(
@Rating nvarchar(50)=null
,@Title nvarchar(255)
,@Year nvarchar(255)=null
,@Rental_Cost money
,@Copies nvarchar(50)=null
,@Plot ntext
,@Genre nvarchar(50)
,@MovieID int =0
)
AS
BEGIN

if(@MovieID >0)
BEGIN

UPDATE [dbo].[Movies]
   SET [Rating] = @Rating
      ,[Title] = @Title
      ,[Year] = @Year
      ,[Rental_Cost] = @Rental_Cost
      ,[Copies] = @Copies
      ,[Plot] = @Plot
      ,[Genre] = @Genre
 WHERE MovieID = @MovieID

END
ELSE
BEGIN



INSERT INTO [dbo].[Movies]
           ([Rating]
           ,[Title]
           ,[Year]
           ,[Rental_Cost]
           ,[Copies]
           ,[Plot]
           ,[Genre])
     VALUES
           (@Rating
           ,@Title
           ,@Year
           ,@Rental_Cost
           ,@Copies
           ,@Plot
           ,@Genre)
END
END



GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRentalReturnMovie]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateRentalReturnMovie]
(
@rentalID int
)
AS

BEGIN


UPDATE [dbo].[RentedMovies]
   SET  [DateReturned] = GETDATE()
 WHERE RMID =@rentalID
END


GO
/****** Object:  StoredProcedure [dbo].[userLogin]    Script Date: 14-06-2020 09:24:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec userLogin 'mk','welcome'
CREATE procedure [dbo].[userLogin] 
@userID varchar(100),
@pwd Nvarchar(510)
as
Begin
		
select * from Login where LoginID=@userID and Password=@pwd

	
End


GO
USE [master]
GO
ALTER DATABASE [RentalVideo_Balkaran] SET  READ_WRITE 
GO
