USE PRG271_Project

CREATE TABLE Modules
(
    Code INT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Description VARCHAR(500),
    URLLink NVARCHAR(MAX)
);