-- ****************************************** Mohamed Emad ******************************************
-- ***1
CREATE PROCEDURE SP_AddEmployee
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @NationalID CHAR(14),
    @PhoneNumber VARCHAR(11),
    @FixedSalary DECIMAL(9, 2),
    @Type BIT
AS
BEGIN
    INSERT INTO Employee (FirstName, LastName, NationalID, PhoneNumber, FixedSalary, Type)
    VALUES (@FirstName, @LastName, @NationalID, @PhoneNumber, @FixedSalary, @Type)
END

go

-- ***2.1
CREATE PROCEDURE SP_UpdateEmployeeInfo
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @NationalID CHAR(14),
    @PhoneNumber VARCHAR(11),
    @Type BIT
AS
	BEGIN
		UPDATE Employee
		SET FirstName = @FirstName,
			LastName = @LastName,
			PhoneNumber = @PhoneNumber,
			Type = @Type
		WHERE NationalID = @NationalID
	END

go

-- ***2.2
CREATE PROCEDURE SP_UpdateEmployeeSalary
    @NationalID CHAR(14),
    @FixedSalary DECIMAL(9, 2)
AS
	BEGIN
		UPDATE Employee
		SET FixedSalary = @FixedSalary
		WHERE NationalID = @NationalID
	END

go

-- ***3
CREATE PROCEDURE SP_CreateManagerAccount
    @UserName VARCHAR(50),
    @UserPassword VARCHAR(50),
    @EmployeeID CHAR(14)
AS
	BEGIN
		INSERT INTO Account (UserName, UserPassword, EmployeeID)
		VALUES (@UserName, @UserPassword, @EmployeeID)
	END

go

-- ***4
CREATE PROCEDURE SP_DeleteManagerAccount
    @UserName VARCHAR(50)
AS
	BEGIN
		DELETE FROM Account WHERE UserName = @UserName
	END

go
-- *************************************************************************************************

-- ****************************************** Fares Ahmed ******************************************
-- 1-Add Service
create or alter procedure SP_AddService
    @ServiceName nvarchar(100),
    @Price int
as
	begin
		insert into [dbo].[Service] ([ServiceName], [Price])
		values (@ServiceName, @Price);
		--select SCOPE_IDENTITY() AS NewServiceID;
	end;

go

-- 2-delete service 
create or alter procedure SP_DeleteService
    @ServiceID int
as
	begin
		if exists (select 1 from [dbo].[Service] where [ID] = @ServiceID)
			begin
				delete from [dbo].[Service]
				where [ID] = @ServiceID;
				print 'Service successfully deleted.';
			end
		else
			begin
				print 'Service with the provided ID does not exist.';
			end
	end;

go

-- 3-update Service
create or alter procedure SP_UpdateService
    @ServiceId int,
    @ServiceName nvarchar(100),
    @Price int
as
	begin
		if exists (select 1 from [dbo].[Service] where [ID] = @ServiceId)
			begin
				update [dbo].[Service]
				set [ServiceName] = @ServiceName,
					[Price] = @Price
				where [ID] = @ServiceId;
				print 'service successfully updated.';
			end
		else
			begin
				print 'service with the provided id does not exist.';
			end
	end;

go

--- 4-add package
create or alter procedure SP_AddPackage
    @Name nvarchar(50),
    @Description nvarchar(MAX),
    @TotalAmount decimal(18, 2)
as
	begin
		insert into [dbo].[Package] (Name, Description, TotalAmount)
		values (@Name, @Description, @TotalAmount);
		--select SCOPE_IDENTITY() as NewPackageID;
	end

go

-- 5-delete package
create or alter procedure SP_DeletePackage
    @PackageId int
as
	begin
		if exists (select 1 from [dbo].[Package] where [id] = @PackageId)
			begin
				delete from [dbo].[Package] where [ID] = @PackageId;
				select 'package deleted successfully.' as message;
			end
		else
			begin
				select 'package not found.' as message;
			end
	end;

go

-- 6-update package
create or alter procedure SP_UpdatePackage
    @PackageId int,
    @Name nvarchar(50),
    @Description nvarchar(max),
    @TotalAmount decimal(18, 2)
as
	begin
		-- check if the package exists
		if exists (select 1 from [dbo].[Package] where [ID] = @PackageId)
			begin
				-- if it exists, update the package
				update [dbo].[Package]
				set 
					[Name] = @Name,
					[Description] = @Description,
					[TotalAmount] = @TotalAmount
				where [ID] = @PackageId;
				select 'package updated successfully.' as message;
			end
		else
			begin
				select 'package not found.' as message;
			end
	end;

go

-- -7the monthly evaluation
create or alter procedure SP_SetMonthlyEvaluation
    @Id int,
    @Month nvarchar(20),
    @TotalAmountofMonth decimal(18, 2),
    @ProfitPercentage decimal(2, 1),
    @NationalId char(14)
as
begin
    set nocount on;

    -- insert or update evaluation
    if exists (select 1 from [dbo].[Evaluation] where [ID] = @Id)
    begin
        update [dbo].[Evaluation]
        set [Month] = @Month,
            [TotalAmountOfMonth] = @TotalAmountofMonth,
            [ProfitPercentage] = @ProfitPercentage,
            [NationalID] = @NationalId
        where [ID] = @Id;
    end
    else
    begin
        insert into [dbo].[Evaluation] ([ID], [Month], [TotalAmountOfMonth], [ProfitPercentage], [NationalID])
        values (@Id, @Month, @TotalAmountofMonth, @ProfitPercentage, @NationalId);
    end
end;

go

-- *************************************************************************************************

-- ***************************************** Mahmoud Mokhter ***************************************
-- 1
CREATE PROCEDURE SP_AddCustomer(@C_Name VARCHAR(100), @C_Phone VARCHAR(11))
	as
	BEGIN
		INSERT INTO Customer (Name, PhoneNumber)
		VALUES (@C_Name, @C_Phone);
	END

go

-- 2
CREATE PROCEDURE SP_AddEmployeeServesCustomer(
    @p_NationalID VARCHAR(20),
    @p_CustomerCode INT,
    @p_ServiceID INT,
    @P_ServDate Date
)
as
	BEGIN
		INSERT INTO Serve (NationalID, CustomerId, ServiceID, Servedate)
		VALUES (@p_NationalID, @p_CustomerCode, @p_ServiceID, @P_ServDate);
	END

go

-- *************************************************************************************************

-- ********************************************** Hosni ********************************************
-- 1
create procedure SP_InsertArrivalTime @EmpID char(14)
as
	insert into Attendance (NationalID , ArrivalTime , ExpenseMoney)
	values (@EmpID , getdate() , 0)

go

-- 2
create procedure SP_UpdateLeavingTime @AttendanceID int
as
	update Attendance set
	DepartureTime = GETDATE()
	where AttendanceID = @AttendanceID 

go

-- 3
create procedure SP_UpdateExpenseMoney @AttendanceID int , @ExpenseMoney decimal
as
	begin
		declare @EmpFixedSalary char(14)
		declare @RemindAmount decimal
		declare @CurrentExpenseMoney decimal

		select @EmpFixedSalary =  E.FixedSalary
		from Employee E , Attendance A
		where A.AttendanceID = @AttendanceID
		and E.NationalID = A.NationalID

		select @CurrentExpenseMoney = ExpenseMoney 
		from Attendance
		where AttendanceID = @AttendanceID

		set @RemindAmount = @EmpFixedSalary - @CurrentExpenseMoney

		if(@RemindAmount >= @ExpenseMoney)
			begin
				update Attendance set
				ExpenseMoney += @ExpenseMoney 
				where AttendanceID = @AttendanceID
			end
		else
			select 'Can not Withdraw greater than your fixed money'
	end

go

-- *************************************************************************************************

-- **************************************** Eslam Waheed *******************************************
-- *** 1
create procedure SP_EmployeeReport
(
    @EmployeeID int,
    @StartDate date,
    @EndDate date
)
as
	begin
		select (E.FirstName + ' ' + E.LastName) as EmployeeName, count(SR.CustomerID) as CustomerCount
		from Serve SR inner join Employee E
		on SR.NationalID = E.NationalID
		where SR.NationalID = @EmployeeID and SR.Servedate between @StartDate and @EndDate
		group by E.FirstName, E.LastName;
	end

go

-- *** 2.1
create procedure SP_GetCustomerByPhoneNumber
(
    @PhoneNumber varchar(11)
)
as
	begin
		select Code, [Name], PhoneNumber
		from Customer
		where PhoneNumber = @PhoneNumber;
	end

go

-- ***2.2
create procedure SP_GetCustomerServicesByPhoneNumber
(
    @PhoneNumber varchar(11)
)
as
	begin
		select s.ServiceName, s.Price, se.Servedate
		from Service s inner join serve se 
		on s.ID = se.ServiceId
		inner join Customer c 
		on se.CustomerId = c.Code
		where c.PhoneNumber = @PhoneNumber;
	end

go

-- ***2.3
create procedure SP_GetCustomerPackagesByPhoneNumber
(
    @PhoneNumber varchar(11)
)
as
	begin
		select p.Name as PackageName, p.Description, p.TotalAmount, pc.TakeDate
		from Package p inner join PackageCustomer pc 
		on p.ID = pc.PackageId
		inner join Customer c 
		on pc.CustomerId = c.Code
		where c.PhoneNumber = @PhoneNumber;
	end

go

-- *************************************************************************************************