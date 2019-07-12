-- 维修单详情 
CREATE TABLE [dbo].[RepairListInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RlId] INT NOT NULL,					-- 维修单
    [GId] INT NOT NULL,						-- 配件ID
    [GtId] INT NOT NULL,					-- 配件型号
    [Count] INT NOT NULL,					-- 数量
    [Remark] NVARCHAR(1000) NOT NULL        -- 备注
)
