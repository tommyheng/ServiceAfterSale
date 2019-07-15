-- 货品型号
-- type 产品型(进货时候用) ：0, 维修配件(维修详情时用)：1
CREATE TABLE [dbo].[GoodsType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Type] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL 
)
