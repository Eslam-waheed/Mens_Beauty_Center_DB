
--- view Service
go
create or alter view VW_Service AS
select 
    ServiceName as Name,
    Price as Cost
from 
    dbo.Service;
go


---- view Packages

-- View with alias for all columns
go
create or alter view VW_Package as
select 
    Name as PackageName,
    Description as PackageDescription,
    TotalAmount as PackageTotalAmount
from 
    dbo.Package;
	go




