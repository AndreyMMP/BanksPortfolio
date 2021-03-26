use banksportfolio

create or alter function fn_GetTradeCategory(@tradeValue float, @tradeClientSector int)
returns int
as
begin

declare @TradeValueRange float
select @TradeValueRange = 1000000

declare @result int
	if Exists(select Id from ClientSector where Id = @tradeClientSector)
	begin
		if(@tradeValue <= @TradeValueRange and @tradeClientSector = 1)
		select @result = 1

		if(@tradeValue > @TradeValueRange and @tradeClientSector = 1)
		select @result = 2

		if(@tradeValue > @TradeValueRange and @tradeClientSector = 2)
		select @result = 3
	end

	else
	begin
		select @result = cast('Client Sector not found' as int)
	end

	return @result
	
end

create or alter PROCEDURE sp_PersistInformationFromCheckedTrades
@tradeName varchar(60),
@tradeValue float,
@tradeClientSector int
as
if Exists(select Id from ClientSector where Id = @tradeClientSector)
insert into CheckedTrade (Name, Value, ClientSectorId) Values (@tradeName, @tradeValue, @tradeClientSector)

declare @temp int
select @temp = SCOPE_IDENTITY()

declare @tradeCategoryId int
select @tradeCategoryId = dbo.fn_GetTradeCategory(@tradeValue, @tradeClientSector)

insert into CheckedTradeResult (CheckedTradeId, TradeCategoryId) Values (@temp, @tradeCategoryId)


--USAGE
--exec sp_PersistInformationFromCheckedTrades @tradeName = 'Trade1', @tradeValue = 2000000, @tradeClientSector = 2
--exec sp_PersistInformationFromCheckedTrades @tradeName = 'Trade2', @tradeValue = 400000, @tradeClientSector = 1
--exec sp_PersistInformationFromCheckedTrades @tradeName = 'Trade3', @tradeValue = 400000, @tradeClientSector = 1
--exec sp_PersistInformationFromCheckedTrades @tradeName = 'Trade4', @tradeValue = 3000000, @tradeClientSector = 1

--CHECK
--select ct.Name, td.Name from CheckedTradeResult ctr
--inner join CheckedTrade ct ON ct.Id = ctr.CheckedTradeId
--inner join TradeCategory td ON td.Id = ctr.TradeCategoryId

