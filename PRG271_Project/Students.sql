USE PRG271_Project

CREATE TABLE Students
(
    Number INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Surname VARCHAR(255) NOT NULL,
    Image VARBINARY(MAX),
    DateOfBirth DATETIME NOT NULL,
    Gender VARCHAR(255),
    Phone VARCHAR(20),
    Address VARCHAR(MAX)
);

CREATE TABLE StudentModules
(
    StudentID INT,
    ModuleID INT,
    PRIMARY KEY (StudentID, ModuleID),
    FOREIGN KEY (StudentID) REFERENCES Students(Number),
    FOREIGN KEY (ModuleID) REFERENCES Modules(Code)
);