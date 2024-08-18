-- Add Service
go
create or alter procedure SP_AddService
    @ServiceName nvarchar(100),
    @Price int
as
begin
    insert into [dbo].[Service] ([ServiceName], [Price])
    values (@ServiceName, @Price);
    select SCOPE_IDENTITY() AS NewServiceID;
end;

----*****************************************************************************

--- delete service 
go
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

----*****************************************************************************

-- update Service
go
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


----*****************************************************************************

--- add package
go
create or alter procedure SP_AddPackage
    @Name nvarchar(50),
    @Description nvarchar(MAX),
    @TotalAmount decimal(18, 2)
as
begin
    insert into [dbo].[Package] (Name, Description, TotalAmount)
    values (@Name, @Description, @TotalAmount);
    select SCOPE_IDENTITY() as NewPackageID;
end


----*****************************************************************************

--- delete package
go
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


---************************************************************************************

--- update package
go
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



---*************************************************************************************************

-- *********** ques
go
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









