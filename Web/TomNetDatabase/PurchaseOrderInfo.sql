-- 进货单详情
CREATE TABLE [dbo].[PurchaseOrderInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PoId] INT NOT NULL,						-- 进货单id PurchaseOrder.id
    [GId] INT NOT NULL,							-- 货物 goods.id
    [GtId] INT NOT NULL,						-- 货物类型goodstype.id
    [Count] INT NOT NULL,						-- 数量
    [Remark] NVARCHAR(1000) NOT NULL,			-- 备注	
    [Cost] MONEY NOT NULL,						-- 费用
    [Test] BIT NOT NULL,						-- 测试状态 1：通过 0：不通过
    [Rework] INT NOT NULL,						-- 备注
    [Guarantee] DATETIME NOT NULL,				-- 保修时间
    [IsBack] BIT NOT NULL,						-- 是否返货 1：返货 0：未返货
    [BackTime] DATETIME NOT NULL,				-- 返修时间
    [EId] INT NOT NULL,							-- 快递公司
    [Enumber] NVARCHAR(50) NOT NULL,			-- 快递单号
    [SendId] INT NOT NULL,					    -- 发货人 userlogin.id
    [RepairType] INT NOT NULL					-- 维修类型 0:待维修 1:完成 2:无法维修
)
