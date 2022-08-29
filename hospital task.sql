create database Hospital
use Hospital

create table doctor(d_id int primary key identity, doc_name nvarchar(20), experience nvarchar(20),speciality nvarchar(20))
insert into doctor values('Rahul',3,'Surgeon')
insert into doctor values('Mukul',12,'Paediatrician')
insert into doctor values('Aadya',15,'Dentist')
insert into doctor values('Vaishnav',9,'Chiropractor')
insert into doctor values('Shivam',7,'Cardiologist')

drop table doctor

create procedure sp_doctorList
as
begin
select * from doctor
end
exec sp_doctorList;

drop table doctor_log


create table doctor_log(Doc_id int identity(140,1),Operation nvarchar(20),Updateddate Datetime )
select* from doctor_log

drop procedure sp_doctorList

 create trigger doctorInsertTrigger
 on doctor
 for insert
 as 
 insert into doctor_log(Doc_id,Operation,updateddate)
 select d_id,'Data Inserted', GETDATE() from inserted

 drop trigger doctorInserttrigger
 insert into doctor values ('Sourabh ',20 ,'Lungs Specialist')

 SET IDENTITY_INSERT dbo.doctor_log ON

create table patient(p_id int primary key identity, pa_name nvarchar(20), age nvarchar(20),address nvarchar(20),appointment_type nvarchar(20))
insert into patient values('Anshika',65,'Delhi','New Patient')
insert into patient values('Ramil',44,'Haryana','Returning Patient')
insert into patient values('Shalini',25,'Noida','New Patient')
insert into patient values('Kishor',78,'Haridwar','Returning Patient')
insert into patient values('Rohit',37,'Gurugram','New Patient')

drop table patient
--Stored Procedures 

create procedure sp_patientList
as 
begin
select * from patient
end
drop procedure sp_patientList
exec sp_patientList;

-- trigger implementation


 create table patient_log(LogID int identity(100,1),p_id int, Operation nvarchar(20), updateddate Datetime);
 drop table patient_log
 select * from patient_log;


 create trigger patientInsertTrigger
 on patient
 for insert
 as 
 insert into patient_log(p_id,Operation,updateddate)
 select p_id,'Data Inserted', GETDATE() from inserted


 insert into patient values ('Shyam',34,'Rajasthan', 'New Patient');




create table bed(b_id int primary key identity(500,1), availability nvarchar(20), bed_type nvarchar(20))
insert into bed values('Yes','Deluxe')
insert into bed values('Yes','Normal')
insert into bed values('No','Deluxe')
insert into bed values('Yes','Normal')
insert into bed values('No','Normal')

drop table bed


 drop table booked_table


 --Stored Procedures 

create procedure sp_bedList
as 
begin
  select * from bed;
end

exec sp_bedList;
drop procedure sp_bedList


--trigger

create table bed_log(LogID int identity(100,1),b_id int, Operation nvarchar(20), updateddate Datetime);
 drop table bed_log
 select * from bed_log;


 create trigger bedInsertTrigger
 on bed
 for insert
 as 
 insert into bed_log(b_id,Operation,updateddate)
 select b_id,'Data Inserted', GETDATE() from inserted

insert into bed values('Yes','Deluxe')