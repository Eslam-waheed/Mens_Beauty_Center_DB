-- create the Employee table
-- done 1
create table Employee 
(
  FirstName nvarchar(50) not null,
  LastName nvarchar(50) not null,
  NationalID char(14) check (len(NationalID)=14) primary key,
  PhoneNumber VARCHAR(11) CHECK (len(PhoneNumber) = 11 and PhoneNumber LIKE '01[0125][0-9]%') not null,
  FixedSalary decimal(9, 2) not null,
  [Type] bit
);

-- create the Customer table
-- done 2
create table Customer (
    Code int identity(1,1) primary key,
    [Name] nvarchar(50) not null,
    PhoneNumber VARCHAR(11) unique not null,
	constraint CK_PhoneNumber_Validation check(len(PhoneNumber) = 11 and PhoneNumber like '01[0125][0-9]%')
);


-- create the Package table
-- done 3
create table Package (
    ID int identity(1,1) primary key,
    Name nvarchar(50) not null,
    Description nvarchar(max) not null,
    TotalAmount decimal(18, 2) not null
);


-- Create Service Table
-- done 4
create table Service
(
	ID int identity(1,1),
	ServiceName nvarchar(100) not null ,
	Price int not null ,
	constraint PK_Service primary key(ID)
);

-- Create Account Table
--done
create table Account
(
	UserName varchar(50),
	UserPassword varchar(50) not null,
	EmployeeID char(14) check (len(EmployeeID)=14 AND EmployeeID like '[0-9]%'),
	constraint PK_Account primary key(userName),
	constraint FK_Emp_Account foreign key(EmployeeID) references Employee(NationalID)
);


-- Create the relationship between Package and Customer
--done
create table PackageCustomer (
    CustomerId int foreign key references Customer(Code),
    PackageId int foreign key references Package(ID),
    Deposit decimal(9, 2) not null,
    TakeDate date not null,
    primary key (CustomerId, PackageId)
);


-- create the Serve table
-- done
create table serve (
    NationalID char(14) check (len(NationalID)=14 AND NationalId like '[0-9]%') NOT NULL,
    CustomerId int foreign key references Customer(Code),
    ServiceId int foreign key references Service(ID),
    Servedate date not null,
    primary key (NationalId, CustomerId, ServiceId),
	CONSTRAINT FK_Employee_NationalID_serve FOREIGN KEY (NationalID) REFERENCES Employee(NationalID)
);


--done
create table Attendance (
    AttendanceID int identity(1,1) primary key,
    NationalID char(14) check (len(NationalID)=14 AND NationalId like '[0-9]%') NOT NULL,
    ExpenseMoney DECIMAL(9, 2),
    ArrivalTime datetime,
    DepartureTime datetime,
    DailyPocketMoney DECIMAL(9, 2),
    
    CONSTRAINT FK_Employee_NationalID FOREIGN KEY (NationalID) REFERENCES Employee(NationalID)
);


-- table Evaluation 
--done
create table Evaluation
(
    [Month] nvarchar(10) not null,
    TotalAmountOfMonth decimal(18, 2) not null,
    ProfitPercentage decimal(2, 1) not null,
    Bonus as (TotalAmountOfMonth * ProfitPercentage / 100), 
    NationalID char(14) check (len(NationalID)=14 AND NationalID like '[0-9]%') not null,
    constraint FK_Evaluation_Employee foreign key (NationalID) references Employee(NationalID),
    constraint PK_Evaluation primary key (Month, NationalID)
);