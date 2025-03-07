CREATE TABLE Orders
(
    OrderId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    BusinessDate DATETIME,
    CreatedAt DATETIME DEFAULT GETDATE()
)

ALTER TABLE [dbo].[Orders]
    ADD [Status] VARCHAR(250) NULL
GO

INSERT INTO [takpos].[dbo].[Orders]
(
    [OrderId],
    [BusinessDate],
    [CreatedAt],
    [Status]
)
VALUES  
('','','','')

CREATE TABLE OrderProducts
(
    OrderProductId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    OrderId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES [takpos].[dbo].[Orders](OrderId),
    ProductDescription VARCHAR(100),
    Quantity INT,
    Size VARCHAR(100),
    Price DECIMAL(18,2),
    BusinessDate DATETIME,
    CreatedAt DATETIME DEFAULT GETDATE()
)
