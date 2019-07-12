-- 维修单
CREATE TABLE [dbo].[RepairList]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PoId] INT NOT NULL,						-- 进货单
    [PoiId] INT NOT NULL,						-- 进货单详情单
    [GoodsNumber] NVARCHAR(50) NOT NULL,	    -- 商品条形码
    [RepairId] INT NOT NULL						-- 维修人员 userlogin.id
)
