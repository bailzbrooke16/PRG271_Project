INSERT INTO Students (Number, Name, Surname, Image, DateOfBirth, Gender, Phone, Address)
VALUES
    (1, 'John', 'Doe', NULL, '1990-01-01', 'Male', '123-456-7890', '123 Main St'),
    (2, 'Jane', 'Smith', NULL, '1995-05-15', 'Female', '987-654-3210', '456 Oak St'),
    (3, 'Michael', 'Johnson', NULL, '1992-09-20', 'Male', '555-123-4567', '789 Pine St'),
    (4, 'Emily', 'Williams', NULL, '1998-03-10', 'Female', '222-333-4444', '567 Elm St'),
    (5, 'Daniel', 'Miller', NULL, '1993-07-05', 'Male', '111-222-3333', '890 Birch St');


INSERT INTO StudentModules (StudentID, ModuleID)
VALUES
    (1, 101),
    (1, 102), 
    (2, 102), 
    (3, 101),
    (3, 103),
    (4, 104),
    (5, 105);