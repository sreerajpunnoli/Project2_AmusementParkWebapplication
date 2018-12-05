USE [HalifaxAmusementPark]
GO

/****** Object:  Table [dbo].[TicketDetail]    Script Date: 2018-12-05 3:28:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TicketDetail](
	[TicketDay] [date] NOT NULL,
	[AvailableSeatCount] [int] NULL,
 CONSTRAINT [PK_dbo.TicketDetail] PRIMARY KEY CLUSTERED 
(
	[TicketDay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

