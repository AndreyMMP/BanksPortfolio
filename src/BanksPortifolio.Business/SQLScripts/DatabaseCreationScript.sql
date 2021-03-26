create database banksportfolio

use banksportfolio

create table ClientSector(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(60) NOT NULL
)

insert into ClientSector (Name) Values ('PUBLIC')
insert into ClientSector (Name) Values ('PRIVATE')

select * from ClientSector

create table CheckedTrade(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(60) NOT NULL,
	Value float NOT NULL,
	ClientSectorId int FOREIGN KEY REFERENCES ClientSector(Id)
)

select * from CheckedTrade

create table TradeCategory(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(60) NOT NULL
)

insert into TradeCategory (Name) Values ('LOWRISK')
insert into TradeCategory (Name) Values ('MEDIUMRISK')
insert into TradeCategory (Name) Values ('HIGHRISK')

select * from TradeCategory

create table CheckedTradeResult(
	Id int IDENTITY(1,1) PRIMARY KEY,	
	CheckedTradeId int FOREIGN KEY REFERENCES CheckedTrade(Id),
	TradeCategoryId int FOREIGN KEY REFERENCES TradeCategory(Id)
)

select * from CheckedTradeResult