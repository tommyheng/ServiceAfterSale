﻿-- 货品型号
CREATE TABLE [dbo].[GoodsType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GId] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL
)
