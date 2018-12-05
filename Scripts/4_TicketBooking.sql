USE [HalifaxAmusementPark]
GO

/****** Object:  Table [dbo].[TicketBooking]    Script Date: 2018-12-05 3:28:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TicketBooking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BookedTicketDate] [date] NOT NULL,
	[SeatsCount] [int] NOT NULL,
	[TransactionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.TicketBooking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

