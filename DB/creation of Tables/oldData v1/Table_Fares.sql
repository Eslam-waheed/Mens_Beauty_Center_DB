create database Barber

CREATE TABLE Employee
(
  FirstName NVARCHAR(50),
  LastName NVARCHAR(50),
  NationalID CHAR(14) CONSTRAINT PK_Employee PRIMARY KEY CHECK (LEN(NationalID) = 14),
  PhoneNumber VARCHAR(11) CHECK (PhoneNumber LIKE '01[0125][0-9]%'),
  FixedSalary DECIMAL(18, 2),
  [Type] NVARCHAR(20)
);
insert into Employee values ('fares','ahmed','12345678912345','01014735550',150,'true');

INSERT INTO Employee (FirstName, LastName, NationalID, PhoneNumber, FixedSalary, [Type]) 
VALUES ('fares', 'Ahmed', '12345678901234', '01012345678', 200.00, 'Full-Time');


create table Evaluation
(
    ID int constraint PK_Evaluation_ID primary key, 
    Month nvarchar(20),
    TotalAmountOfMonth decimal(18, 2),
    ProfitPercentage decimal(5, 2),
    Bonus as (TotalAmountOfMonth * ProfitPercentage / 100), 
    NationalID char(14),
    constraint FK_Evaluation_Employee foreign key (NationalID) references Employee(NationalID) 
);

insert into Evaluation values (1,5,1000,5,'12345678901234')

select * from Evaluation




