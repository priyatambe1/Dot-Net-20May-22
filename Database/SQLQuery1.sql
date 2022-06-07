  
  create database db1;
  Drop database db1;
 
  --Create table
/*
create table <TABLE NAME>(<columns> data-type)
*/
 create database db2;
 create table sample(id int,name varchar(200));
 
  select * from sample;
 

  insert into sample values(1,'Priyanka');
  insert into sample values(2,'Priya');
  insert into sample values(3,'Suru');
  insert into sample values(4,'Surbhi');
  insert into sample values(5,'Priya 2');

   select * from sample where id=3;

  delete from sample where name='Priya 2';
  update sample set name='Riya' where id=2;

  create table employee(id int,name varchar(100),salary float,gender varchar(50));
  select * from employee;
  

  insert into employee values(1,'Priya',100,'Female');
  insert into employee values(2,'Riya',500,'Female');
  insert into employee values(3,'kriya',1000,'Female');
  insert into employee values(4,'Shree',200,'Male');
  insert into employee values(5,'Rey',400,'Male');
  
  delete from employee where salary=100;
  update employee set salary=2000 where id=2;
  select * from employee where gender='Female';
  delete  from employee where id=1;          --deleting rows
  
  alter table employee add designation varchar(100)

  update employee set designation='SE' where id=2  
  update employee set designation='ASE' where id=3
  update employee set designation='AC' where id=4
  update employee set designation='SC' where id=5

  select * from employee order by id desc 
  select * from employee order by id asc 

  select * from employee where id in (2,3,4)
  select * from employee where id not in (2,3,4)

  select max(id) from employee 
  select min(id) as id from employee
  select AVG(id) as id from employee
  select count(*) from employee 

  select  * from employee where name like 'R%'

  select  * from employee where name like '%i%'

  select CONCAT(name,' ',designation) as name from employee          --to join to columns

  select gender from employee group by gender 

  select name from employee group by name having count(*)>1; 

create table employee1 (id int,name varchar(200),departmentid int)
create table department(id int,department varchar(20))

insert into employee1 values(1,'Priyanka',1)
insert into employee1 values(2,'Rohan',2)
insert into employee1 values(3,'Rina',1)
insert into employee1 values(4,'Sourabh',3)

insert into department values(1,'IT')
insert into department values(2,'Sales')
insert into department values(4,'Admin')

select * from employee1
select * from department

select emp.name,dep.department from employee1 as emp inner join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee1 as emp left join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee1 as emp right join department as dep on emp.departmentid=dep.id

select * from employee1 as emp inner join department as dep on emp.departmentid=dep.id;