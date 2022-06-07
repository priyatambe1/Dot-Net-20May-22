select * from employee1
select * from department

select * from employee1 emp full outer join department dep on emp.departmentid = dep.id;
select * from employee1 emp left outer join department dep on emp.departmentid = dep.id;
select * from employee1 emp right outer join department dep on emp.departmentid = dep.id;

--Task to show rollNo, FullName, gender, className
create database sampledb
create table student(rollNo  int,firstName varchar(200),lastName varchar(200),gender varchar(100),classId int);
create table class(id  int,className varchar(200));

insert into student values(1,'Priyanka','Tambe','Female',2)
insert into student values(2,'Riya','Ghatge','Female',1)
insert into student values(3,'Sarang','Kumar','Male',2)
insert into student values(4,'Suraj','Patil','Male',4)
insert into student values(5,'Niki','Pawar','Female',3)

insert into class values(1,'v')
insert into class values(2,'II')
insert into class values(3,'IV')
insert into class values(4,'X')

select * from student
select * from class

select rollNo,CONCAT(FirstName,' ',LastName) as FullName, gender, className from student s inner join class c on s.classId = c.id

/*  Function
create function <function-name>(<parameters>) returns data-type as
begin
//body
end
*/
create function GetFullName(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT(firstName,' ',lastName) as FullName from student where rollNo=@ID);
End

select * from student
select dbo.GetFullName(3) ;


-- return empId


create function GetEmployeeId(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT('EMP',id) as EMPID from employee1 where id=@ID);
End

select * from employee1
select dbo.GetEmployeeId(3);



--Procedure
select * from employee
select * from department
create proc AddEmployee(@Id int,@Name varchar(200),@DepartmentId int)
As 
Begin

insert into employee values(@Id,@Name,@DepartmentId);
END


exec dbo.AddEmployee 'Priyanka','IT'


create table employee (id int IDENTITY(1,1),name varchar(200),departmentid int)
create table department(id int IDENTITY(1,2),department varchar(20))

create proc getStudents as begin 
select * from employee emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;
end 

exec getStudents