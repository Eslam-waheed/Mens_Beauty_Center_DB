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
