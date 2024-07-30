CREATE TABLE POS 
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(MAX) NULL,
    password VARCHAR(MAX) NULL,
    role VARCHAR(MAX) NULL,
    status VARCHAR(MAX) NULL,
    date DATE NULL
)

SELECT * FROM POS


CREATE TABLE categories
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    category VARCHAR(MAX) NULL,
    date DATE NULL
)

SELECT * FROM categories


SELECT * FROM POS
CREATE TABLE products (
    id INT PRIMARY KEY IDENTITY,
    prod_id NVARCHAR(50) NOT NULL,
    prod_name NVARCHAR(100) NOT NULL,
    category NVARCHAR(50) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    image_path NVARCHAR(255) NOT NULL,
    status NVARCHAR(50) NOT NULL,
    date_insert DATE NOT NULL
)
SELECT * FROM products