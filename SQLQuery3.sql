﻿CREATE TABLE CAR (
id INT PRIMARY KEY IDENTITY (1,1),
[CarId] VARCHAR(50) NOT NULL,
[BrandId] INT NOT NULL,
[ModelYear] DATETIMEOFFSET NOT NULL,
[DailyPrice] MONEY NOT NULL,
[Description] TEXT NOT NULL  
);
