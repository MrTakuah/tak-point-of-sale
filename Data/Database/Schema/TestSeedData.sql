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