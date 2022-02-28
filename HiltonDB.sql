--drop database Complex_1
--go

create database HiltonCompany
go

use HiltonCompany
go

create function [dbo].[AgeCheck] (@dateOfBith date, @age int)
returns bit
begin
return case when datediff(day, dateadd(year, @age, @dateOfBith), sysdatetime()) > 0 then 1 else 0 end
end
go

create table Positions (
	PositionID integer identity primary key,
	PositionName varchar(800) unique not null,
	Salary decimal(19,2) check (Salary >= 0) not null,
	Responsibilities varchar(max) null,
)
go

create table Accounts (
	AccountID uniqueidentifier primary key default newid(),
	Email varchar(800) unique null,
    PhoneNumber varchar(32) unique null,
	[Password] varchar(64) not null,
	AccessType smallint default 0 not null,
	DateOfRegistration datetime2(3) default sysdatetime(),
)
go

create table Employees (
	EmployeeID integer identity primary key,
	AccountID uniqueidentifier foreign key references Accounts(AccountID) on delete no action on update cascade not null,
	PositionID integer foreign key references Positions(PositionID) on delete no action on update cascade not null,
	LastName varchar(800) not null,
    FirstName varchar(800) not null,
	MiddleName varchar(800) null,
	DateOfBith date check (dbo.AgeCheck(DateOfBith, 14) = 1) not null,
    DateOfEmployment smalldatetime default getdate() not null,
)
go

create table Customers (
    CustomerID integer identity primary key,
	AccountID uniqueidentifier foreign key references Accounts(AccountID) on delete no action on update cascade not null,
    LastName varchar(800) not null,
    FirstName varchar(800) not null,
	MiddleName varchar(800) null,
	DateOfBith date check (dbo.AgeCheck(DateOfBith, 14) = 1) not null,
    DateOfRegistration smalldatetime default getdate() not null,
)
go

create table Hotels (
	HotelID integer identity primary key,
	HotelName varchar(800) not null,
	StarsAmount tinyint check (StarsAmount >= 0 and StarsAmount <= 5) not null,
	RoomsAmount smallint check (RoomsAmount > 0) not null,
	Country varchar(800) not null,
	City varchar(800) not null,
	Phone varchar(800) null,
	Email varchar(800) null,
	FullAddress varchar(800) null,
	INN numeric(10) not null,
	OGRN numeric(13) not null,
	[Site] varchar(800) null,
)
go

create table HotelPhotos (
	HotelPhotoID integer identity primary key,
	HotelID integer foreign key references Hotels(HotelID) on delete cascade on update cascade not null,
	[Source] varchar(800) not null,
	Comment varchar(800) null,
)
go

create table [Services] (
	ServiceID integer identity primary key,
	ServiceName varchar(800) unique not null,
	StandartPrice decimal(19,2) check (StandartPrice >= 0) not null,
)
go

create table HotelServices (
	HotelServiceID integer identity primary key,
	HotelID integer foreign key references Hotels(HotelID) on delete cascade on update cascade not null,
	ServiceID integer foreign key references [Services](ServiceID) on delete cascade on update cascade not null,
)
go

create table HotelRooms (
	HotelRoomID integer identity primary key,
	HotelID integer foreign key references Hotels(HotelID) on delete cascade on update cascade not null,
	RoomName varchar(800) not null,
	NumberOfRooms tinyint check (NumberOfRooms > 0) not null,
	NumberOfBeds tinyint check (NumberOfBeds > 0) not null,
	NumberOfFloors tinyint check (NumberOfFloors > 0) not null,
	RoomPhoto varchar(800) not null,
	Price decimal(19,2) check (Price >= 0) not null,
)
go

create table Orders (
	HotelReservationID integer identity primary key,
	HotelRoomID integer foreign key references HotelRooms(HotelRoomID) on delete set default on update cascade null,
	CustomerID integer foreign key references Customers(CustomerID) on delete set default on update cascade null,
	CheckIn date null,
	CheckOut date null,
	FinalPrice decimal(19,2) check (FinalPrice >= 0) not null,
	Paid bit default 0 not null,
	OrderDateTime datetime2(3) default sysdatetime() not null,
)
go