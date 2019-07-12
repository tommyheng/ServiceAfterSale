-- 进货单
CREATE TABLE [dbo].[PurchaseOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Order] NVARCHAR(50) NOT NULL,						--进货编号							
    [CreateTime] DATETIME NOT NULL DEFAULT getdate(),   --进货时间
    [SaleId] INT NOT NULL,								--销售人员 关联userlogin.id	
    [Guest] NVARCHAR(50) NOT NULL,						--客户名
    [GuestTel] NVARCHAR(50) NOT NULL,					--客户电话
    [AssistantId] INT NOT NULL,							--助理人员 关联userlogin.id
    [AreaId] INT NOT NULL								--维修点
)
