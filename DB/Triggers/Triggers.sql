-- ************************************************** fares *****************************************
--- Trigeers that prevent update on arrivalTime and depatureTime
create or alter trigger trg_PreventUpdateTime
on dbo.Attendance
after update
as
begin
    
    if exists (
        select 1 
        from inserted i
        join deleted d 
        on i.AttendanceID = d.AttendanceID
        where i.ArrivalTime <> d.ArrivalTime 
        or i.DepartureTime <> d.DepartureTime
    )
    begin
        raiserror('Update on ArrivalTime and DepartureTime is not allowed.', 16, 1);
        rollback transaction;
    end
end

go

-- **************************************************************************************************

-- ************************************************** Hosni *****************************************
create trigger Trg_PreventUpdateDelete
on serve
instead of update, delete
as
	begin
		select 'Update Or Delete Operation Is Not Allowed On This Table'
end

go

-- **************************************************************************************************

-- ************************************************** Emad ******************************************
--2. Triggers:
CREATE TABLE ServiceHistory
(
    ServiceID INT,
    OldPrice INT,
    ChangeDate DATE
);

CREATE TABLE PackageHistory
(
    PackageID INT,
    OldTotalAmount DECIMAL(18, 2),
    ChangeDate DATE
)

CREATE TRIGGER trg_UpdateServicePrice
ON Service
AFTER UPDATE
AS
	BEGIN
		INSERT INTO ServiceHistory (ServiceID, OldPrice, ChangeDate)
		SELECT i.ID, d.Price, GETDATE()
		FROM Inserted i JOIN Deleted d 
		ON i.ID = d.ID
	END

CREATE TRIGGER trg_UpdatePackageTotalAmount
ON Package
AFTER UPDATE
AS
	BEGIN
		INSERT INTO PackageHistory (PackageID, OldTotalAmount, ChangeDate)
		SELECT i.ID, d.TotalAmount, GETDATE()
		FROM Inserted i JOIN Deleted d
		ON i.ID = d.ID
	END
-- **************************************************************************************************

-- ************************************************ Mokhter *****************************************
CREATE TRIGGER trg_CalculateSalaryOnDeparture
ON Attendance
AFTER UPDATE
AS
BEGIN
    IF UPDATE(DepartureTime)
    BEGIN
        DECLARE @work_hours DECIMAL(10, 2);
        DECLARE @calculated_salary DECIMAL(10, 2);
        DECLARE @ArrivalTime DATETIME;
        DECLARE @DepartureTime DATETIME;
        DECLARE @ExpenseMoney DECIMAL(10, 2);
        DECLARE @NationalID VARCHAR(20);
        DECLARE @FixedSalary DECIMAL(10, 2);

        -- calc worked hours 
        SET @work_hours = DATEDIFF(HOUR, @ArrivalTime, @DepartureTime);

        -- get Fixed salary from emp table 
        SELECT @FixedSalary = FixedSalary 
        FROM Employee 
        WHERE NationalID = @NationalID;

        -- calc DPM = (WH *(FS/10))-EM
        SET @calculated_salary = (@work_hours * (@FixedSalary / 10)) - @ExpenseMoney;

        -- update daily pocket money
        UPDATE Attendance
        SET DailyPocketMoney = @calculated_salary
        WHERE NationalID = @NationalID;
    END;
END;

-- **************************************************************************************************
