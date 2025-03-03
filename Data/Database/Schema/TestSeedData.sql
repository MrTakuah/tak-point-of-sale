USE takpos
INSERT INTO [takpos].[dbo].[Products]
VALUES 
(newid(),'test',GetDate(), 'Test Coffee') 

select *
from Products

select *
from Persons

use takpos
INSERT INTO [takpos].[dbo].[Persons]
VALUES(NEWID(), 'Tavore','House.Paran@Malazan.com','1234567890')

delete from [takpos].[dbo].[Persons] where PersonId = '8d91f5e4-3794-43df-ac36-183f5568160e'

select *
from PersonOrders

use takpos
INSERT INTO [takpos].[dbo].[PersonOrders]
VALUES()

SELECT *
FROM [takpos].[dbo].[Products]

USE takpos
INSERT INTO [takpos].[dbo].[Products]
VALUES 
(newid(),'test',GetDate(), 'Test Coffee') 

ALTER TABLE takpos.DBO.Products ADD Price DECIMAL;
ALTER TABLE takpos.DBO.Products ADD CreatedAt DATETIME
DELETE FROM Products where ProductId = '22613872-64bd-443d-a0ac-603e23d0b6d2'


USE takpos
INSERT INTO [takpos].[dbo].[Products]
VALUES 
(newid(),'test',GetDate(), 'Test Coffee','2.99') 
USE takpos
INSERT INTO [takpos].[dbo].[Products]
VALUES 
(newid(),'test',GetDate(), 'Test Coffee') 