USE [HalifaxAmusementPark]
GO

/****** Object:  Trigger [dbo].[trig_ticket_book]    Script Date: 2018-12-05 3:29:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create TRIGGER [dbo].[trig_ticket_book] 
   ON  [dbo].[TicketBooking] 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @var int;
	set @var=(select top 1 SeatsCount from TicketBooking order by Id desc);
	--select @var;

	declare @var1 date;
	set @var1=(select top 1 BookedTicketDate from TicketBooking order by Id desc);
	--select @var1;
	

      update TicketDetail
	  set AvailableSeatCount=AvailableSeatCount-@var
	  where TicketDay=@var1; 

	  --select * from TicketDetail;
      

    -- Insert statements for trigger here

END
GO

ALTER TABLE [dbo].[TicketBooking] ENABLE TRIGGER [trig_ticket_book]
GO

