CREATE TABLE Products (
		Id INT,
		"Product_Name" VARCHAR(20),
		PRIMARY KEY(Id)
	);

	INSERT INTO Products
	VALUES
		(1, 'Potato'),
		(2, 'Tomato'),
		(3, 'Lemon'),
		(4, 'Pepper'),
		(5, 'Banana'),
		(6, 'Avocado');


	CREATE TABLE Categories (	
		Id INT,
		"Category_Name" VARCHAR(20),
		PRIMARY KEY(Id)
	);
	
	INSERT INTO Categories
	VALUES
		(1, 'Vegetables'),
		(2, 'Food');


	CREATE TABLE ProductCategories (
		ProductId INT FOREIGN KEY REFERENCES Products(Id),
		CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
		PRIMARY KEY (ProductId, CategoryId)
	);	

	INSERT INTO ProductCategories
	VALUES
		(1, 2),
		(1, 1),
		(2, 2),
		(2, 1),
		(3, 2),
		(4, 1),
		(5, 2);	


	SELECT P.Product_Name, C.Category_Name 
		FROM Products P 
		LEFT JOIN ProductCategories PC ON P.Id = PC.ProductId
		LEFT JOIN Categories C ON C.Id = PC.CategoryId

