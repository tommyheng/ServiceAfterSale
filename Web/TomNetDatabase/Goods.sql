-- 货品表
-- type 进货单 ：0, 维修详情：1
CREATE TABLE [dbo].[Goods]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Type] INT NOT NULL
)
