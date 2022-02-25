USE master
IF EXISTS (SELECT *
FROM sysdatabases
WHERE name='ShoesStoreDB')
DROP DATABASE ShoesStoreDB
CREATE DATABASE ShoesStoreDB
GO
USE ShoesStoreDB
GO
CREATE TABLE Permission
(
    Permission_Id INT IDENTITY PRIMARY KEY,
    [Permission_Name] NVARCHAR(50) NOT NULL
);
CREATE TABLE [User]
(
    [User_Id] INT IDENTITY PRIMARY KEY,
    User_Email NVARCHAR(100) NULL,
    First_Name NVARCHAR(50) NOT NULL,
    Last_Name NVARCHAR(50) NOT NULL,
    Password VARCHAR(1000) NOT NULL DEFAULT 0,
    Address NVARCHAR(100) NULL,
    Phone VARCHAR(15) NULL,
    Permission_Id INT NOT NULL DEFAULT 4,-- 1: Admin && 2: Customer
    FOREIGN KEY (Permission_Id) REFERENCES dbo.Permission(Permission_Id)
);
CREATE TABLE Category
(
    Category_Id INT IDENTITY PRIMARY KEY,
    Category_Name NVARCHAR(255) NOT NULL
);
CREATE TABLE Brand
(
    Brand_Id INT IDENTITY PRIMARY KEY,
    Brand_Name NVARCHAR(255) NOT NULL
);
CREATE TABLE Size
(
    Size_Id INT IDENTITY PRIMARY KEY,
    Size_Name FLOAT NOT NULL
);

CREATE TABLE Product
(
    Product_Id INT IDENTITY PRIMARY KEY,
    Product_Name NVARCHAR(255) NOT NULL,
	Product_Desc NVARCHAR(255) NOT NULL,	
    Price FLOAT DEFAULT 0,
	Create_Date DATETIME DEFAULT GETDATE(),
    Update_Date DATETIME,
    Category_Id INT NOT NULL,
    Brand_Id INT NOT NULL,
	Stock INT NOT NULL,
    FOREIGN KEY (Category_Id) REFERENCES dbo.Category(Category_Id),
    FOREIGN KEY (Brand_Id) REFERENCES dbo.Brand(Brand_Id)
);
CREATE TABLE Size_Product
(
    Size_Product_Id INT IDENTITY PRIMARY KEY,
    Size_Id INT NOT NULL,
	Product_Id INT NOT NULL,	
    FOREIGN KEY (Size_Id) REFERENCES dbo.Size(Size_Id),
    FOREIGN KEY (Product_Id) REFERENCES dbo.Product(Product_Id)
);
CREATE TABLE [Image]
(
    Image_Id INT IDENTITY PRIMARY KEY,
    [Path] NVARCHAR(255) NOT NULL,
    Create_Date DATETIME DEFAULT GETDATE(),
    Update_Date DATETIME,
    Product_Id INT NOT NULL,
    FOREIGN KEY (Product_Id) REFERENCES dbo.Product(Product_Id),
);
CREATE TABLE [Order]
(
    Order_Id INT IDENTITY PRIMARY KEY,
    Order_Date DATETIME NOT NULL DEFAULT GETDATE(),
    Status INT DEFAULT 1,--1: Chờ lấy hàng, 2: Đang giao, 3: Đã giao, 4: Đã hủy, 5: Trả hàng
    Order_Total FLOAT DEFAULT 0,
    Shipping_Date DATETIME,
    [User_Id] INT,
    FOREIGN KEY ([User_Id]) REFERENCES dbo.[User]([User_Id]),
);
CREATE TABLE Order_Details
(
    Order_Details_Id INT IDENTITY PRIMARY KEY,
    Product_Price FLOAT NOT NULL,
    Product_Qty INT NOT NULL,
    Subtotal INT NOT NULL,
    Order_Id INT NOT NULL,
    Product_Id INT NOT NULL,
    FOREIGN KEY (Order_Id) REFERENCES dbo.[Order](Order_Id),
    FOREIGN KEY (Product_Id) REFERENCES dbo.Product(Product_Id),
);
CREATE TABLE Rate
(
    Rate_Id INT IDENTITY PRIMARY KEY,
    Product_Id INT NOT NULL,
    [User_Id] INT NOT NULL,
    Order_Id INT NOT NULL,
    Points INT NOT NULL,
    Content NVARCHAR(255),
    Create_Date DATETIME DEFAULT GETDATE(),
    Update_Date DATETIME NOT NULL,
    IsDeleted BIT DEFAULT 0,
    FOREIGN KEY (Product_Id) REFERENCES dbo.Product(Product_Id),
    FOREIGN KEY ([User_Id]) REFERENCES dbo.[User]([User_Id]),
    FOREIGN KEY (Order_Id) REFERENCES dbo.[Order](Order_Id),
);


GO

--Permission
INSERT INTO Permission
    ([Permission_Name])
VALUES(N'Admin'),
    (N'Customer')
GO

--User
INSERT INTO [User]
	(User_Email, First_Name, Last_Name, Password, Address, Phone, Permission_Id)
VALUES (N'Admin', N'Sam', N'Goodman', N'admin', N'772 North Dr Villa Ridge, Missouri(MO), 63089', 7169379740, 1),
		(N'nico.smith29@gmail.com', N'Smith', N'Nico', N'123456', N'124 Damon Rd Needham Heights, Massachusetts(MA), 02494', 9226852630, 2),
		(N'megane_conroy@gmail.com', N'Megane', N'Conroy', N'123456', N'121 W Main St Pottstown, Pennsylvania(PA), 19465', 5547714494, 2),
		(N'wilber73@gmail.com', N'Wilber', N'Stafford', N'123456', N'6910 Middle Rd 4 Racine, Wisconsin(WI), 53402', 3388576230, 2),
		(N'timothy.zulauf84@gmail.com', N'Timothy', N'Zulauf84', N'123456', N'173 Candlewood Trailer Park Danbury, Connecticut(CT), 06811', 3643898217, 2),
		(N'customer1@gmail.com', N'Derek', N'Levy', N'123456', N'1025 Meadow Dr Cottage Hills, Illinois(IL), 62018', 9799644643, 2)

--Category
INSERT INTO Category
    (Category_Name)
VALUES(N'SNEAKER'),
    (N'SANDALS'),
    (N'ATHLETIC'),
    (N'OUTDOOR'),
    (N'SLIPPERS')
GO

--Brand
INSERT INTO Brand
    (Brand_Name)
VALUES(N'NIKE'),
    (N'AIR JORDAN'),
    (N'ADIDAS'),
    (N'PUMA'),
    (N'DANSKO'),
	('MLB'),	
    (N'ECCO')
GO


--Product
INSERT INTO Product
	(Product_Name, Product_Desc, Price, Create_Date, Update_Date, Category_Id, Brand_Id, Stock)
VALUES
	(N'AIR FORCE 1 LOW LXX "SERENA SUMMIT WHITE"', N'', 3829000, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 1, 1, 10),
	(N'ROSHE TWO BLACK', N'Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning', 1723000, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 1, 1, 11),
	(N'RUNNING REACT ELEMENT 87', N'Bootie construction delivers a snug, comfortable fit / Padded collar provides plush cushioning / Sockliner made of slow-recovery foam enhances comfort and cushioning', 1723000, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 1, 1, 11),
	(N'Adidas Unisex-Adult Adissage Slides Sandal', N'100% Synthetic, Imported, Rubber sole, Shaft measures approximately 6-12 inches from arch, Platform measures approximately 0-3 inches, Boot opening measures approximately 0-3 inches around, Regular fit', 1253000, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 2, 3, 24),
	(N'PUMA Unisex-Adult Leadcat Slide Sandal', N'Imported, Rubber sole, Casual Athletic Sneaker, Leadcat', 891500, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 2, 4, 10),
	(N'PUMA Cool Cat Dark Prismatic', N'fabric', 1563500, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 2, 4, 18),
	(N'ECCO Women X-trinsic Textile Strap Sandal', N'fabric', 3310850, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 2, 7, 13),	
	(N'Dansko Womens Racquel Sport Sandals - lightweight sandals with arch support', N'Made in the USA or Imported, Ethylene Vinyl Acetate sole, Platform measures approximately 1, Multiple points of adjustability, Recycled webbings', 2528000, N'2021-11-05 05:35:51', N'2021-11-05 05:35:51', 2, 5, 19)


GO

--Size
INSERT INTO Size
    (Size_Name)
VALUES(35.5),
    (36.0),
    (36.5),
    (37.0),
    (37.5),
    (38.0),
    (38.5),
    (39.0),
    (39.5),
    (40.0),
    (40.5),
    (41.0),
    (42.0),
    (43.0),
    (44.0),
    (45.0),
    (46.0)
GO

INSERT INTO Size_Product
	(Size_Id, Product_Id)
VALUES
	(4,1),
	(5,1),
	(6,1),
	(6,2),
	(7,2),
	(1,3),
	(2,3),
	(3,3),
	(1,4),
	(2,4),
	(3,4),
	(4,4),
	(5,5),
	(6,5),
	(7,5),
	(8,6),
	(9,6),
	(10,6),
	(11,7),
	(12,7),
	(13,7),
	(14,8),
	(15,8),
	(16,8)
	--17
GO
--Image
INSERT INTO [Image]
	([Path], Create_Date, Update_Date, Product_Id)
VALUES
	(N'https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white_300x.png?v=1643803817', N'08/04/2021', N'08/04/2021', 1),
	(N'https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-2_300x.png?v=1643803817', N'08/04/2021', N'08/04/2021', 1),
	(N'https://cdn.shopify.com/s/files/1/2358/2817/products/nike-air-force-1-low-lxx-serena-summit-white-3_300x.png?v=1643803817', N'08/04/2021', N'08/04/2021', 1),
	(N'http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004.jpg', N'08/04/2021', N'08/04/2021', 2),
	(N'http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_1.jpg', N'08/04/2021', N'08/04/2021', 2),
	(N'http://purchaze.com/pictures/nike-wmns-roshe-two-black-black-844931-004_2.jpg', N'08/04/2021', N'08/04/2021', 2),
	(N'https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/ktfan65igkw4nb8c3jvs/nike-react-element-87-sail-rush-orange-release-date.jpg', N'08/04/2021', N'08/04/2021', 3),
	(N'https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/w20texhnqyxylva0xbgl/nike-react-element-87-sail-rush-orange-release-date.jpg', N'08/04/2021', N'08/04/2021', 3),
	(N'https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/rdim8o3ryfqkzc7anrpd/nike-react-element-87-sail-rush-orange-release-date.jpg', N'08/04/2021', N'08/04/2021', 3),
	(N'https://m.media-amazon.com/images/I/71o4uSF26YL._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 4),
	(N'https://m.media-amazon.com/images/I/61qqMFxGxyL._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 4),
	(N'https://m.media-amazon.com/images/I/71uHDLaWGXL._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 4),
	(N'https://m.media-amazon.com/images/I/71M2oxWCjkS._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 5),
	(N'https://m.media-amazon.com/images/I/715R0-wRKeS._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 5),
	(N'https://m.media-amazon.com/images/I/71ADbn83HWS._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 5),
	(N'https://m.media-amazon.com/images/I/41lyjznmaSL._AC_.jpg', N'08/04/2021', N'08/04/2021', 6),
	(N'https://m.media-amazon.com/images/I/510MaQWslcL._AC_.jpg', N'08/04/2021', N'08/04/2021', 6),
	(N'https://m.media-amazon.com/images/I/71Hm60lorWL._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 7),
	(N'https://m.media-amazon.com/images/I/61FGZx9tVtL._AC_UY675_.jpg', N'08/04/2021', N'08/04/2021', 7),
	(N'https://m.media-amazon.com/images/I/61ju+hAFY3L._AC_UY625_.jpg', N'08/04/2021', N'08/04/2021', 7),	
	(N'https://m.media-amazon.com/images/I/61ZrxFvudzL._AC_UX575_.jpg', N'08/04/2021', N'08/04/2021', 7),
	(N'https://m.media-amazon.com/images/I/71zg2Y4-9+L._AC_UY575_.jpg', N'08/04/2021', N'08/04/2021', 8),
	(N'https://m.media-amazon.com/images/I/61pql62AGKL._AC_UY575_.jpg', N'08/04/2021', N'08/04/2021', 8),
	(N'https://m.media-amazon.com/images/I/61UjkEy3z+L._AC_UY575_.jpg', N'08/04/2021', N'08/04/2021', 8),
	(N'https://m.media-amazon.com/images/I/61w-vJBt1JL._AC_UY575_.jpg', N'08/04/2021', N'08/04/2021', 8)
