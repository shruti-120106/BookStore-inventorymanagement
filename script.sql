USE [Inventory]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[book_name] [varchar](100) NOT NULL,
	[book_author] [varchar](100) NOT NULL,
	[book_type] [varchar](50) NULL,
	[book_price] [decimal](10, 2) NOT NULL,
	[book_description] [text] NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
	[publication_name] [varchar](100) NULL,
	[quantity] [int] NOT NULL,
	[supplier_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[cart_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NOT NULL,
	[book_name] [varchar](255) NOT NULL,
	[quantity] [int] NOT NULL,
	[total_price] [decimal](18, 2) NOT NULL,
	[added_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cart_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[phone_number] [varchar](15) NULL,
	[address] [text] NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
	[email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imagee]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imagee](
	[id] [int] NOT NULL,
	[imgpath] [varchar](50) NULL,
	[imgval] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[inventory_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[book_name] [varchar](255) NULL,
	[initial_stock] [int] NULL,
	[current_stock] [int] NULL,
	[description] [varchar](255) NULL,
	[last_updated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[inventory_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [datetime] NULL,
	[total_amount] [decimal](10, 2) NOT NULL,
	[book_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[status] [varchar](20) NULL,
	[customer_name] [varchar](255) NULL,
	[phone_number] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipts]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipts](
	[receipt_id] [int] IDENTITY(1,1) NOT NULL,
	[receipt_customer_id] [int] NOT NULL,
	[receipt_number] [varchar](50) NOT NULL,
	[receipt_date] [date] NULL,
	[receipt_amount] [decimal](10, 2) NOT NULL,
	[receipt_type] [varchar](50) NULL,
	[receipt_description] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[receipt_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[receipt_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[sales_id] [int] IDENTITY(1,1) NOT NULL,
	[sales_book_id] [int] NOT NULL,
	[sales_quantity] [int] NOT NULL,
	[sales_amount] [decimal](10, 2) NOT NULL,
	[sales_date] [date] NULL,
	[sales_description] [text] NULL,
	[customer_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[sales_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[stock_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[book_name] [varchar](255) NULL,
	[price] [decimal](18, 2) NULL,
	[supplier_price] [decimal](18, 2) NULL,
	[quantity] [int] NULL,
	[supplier_id] [int] NULL,
	[date_added] [datetime] NULL,
	[last_updated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[stock_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[supplier_id] [int] IDENTITY(1,1) NOT NULL,
	[supplier_name] [varchar](100) NOT NULL,
	[contact_person] [varchar](100) NULL,
	[phone_number] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[address] [varchar](255) NULL,
	[category] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25-12-2024 21:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[role] [varchar](20) NOT NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
	[role_new] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT (CONVERT([date],getdate())) FOR [created_at]
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT (CONVERT([date],getdate())) FOR [updated_at]
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT (getdate()) FOR [added_at]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (CONVERT([date],getdate())) FOR [created_at]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (CONVERT([date],getdate())) FOR [updated_at]
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT (getdate()) FOR [last_updated]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [order_date]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ('Processing') FOR [status]
GO
ALTER TABLE [dbo].[Receipts] ADD  DEFAULT (CONVERT([date],getdate())) FOR [receipt_date]
GO
ALTER TABLE [dbo].[Sales] ADD  DEFAULT (CONVERT([date],getdate())) FOR [sales_date]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT (getdate()) FOR [date_added]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT (getdate()) FOR [last_updated]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([date],getdate())) FOR [created_at]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([date],getdate())) FOR [updated_at]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('customer') FOR [role_new]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Supplier] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[Suppliers] ([supplier_id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Supplier]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Receipts]  WITH CHECK ADD FOREIGN KEY([receipt_customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([sales_book_id])
REFERENCES [dbo].[Books] ([book_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [fk_customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [fk_customer]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([supplier_id])
REFERENCES [dbo].[Suppliers] ([supplier_id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([role]='customer' OR [role]='admin'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK__Users__role_new__282DF8C2] CHECK  (([role_new]='employee' OR [role_new]='customer' OR [role_new]='admin'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK__Users__role_new__282DF8C2]
GO
