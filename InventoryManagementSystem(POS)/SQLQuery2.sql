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