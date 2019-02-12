use msdb;
-- laver en if statment så hvis databesen er allerel exixteret så fjerner man databasen og laver en loop så kan den køre som en loop
if db_id ('TT') is not null
begin 
drop database TT 
end 

create database TT;

use TT
--laver table

create table Registrering (
ID int identity(1,1) not null,
Fornavn varchar(10) not null,
Efternavn varchar(20) not null, 
Nummerplade nvarchar (10) not null,
dato date not null,
kilometre int not null
);

--insert into Registrering --(Fornavn,Efternavn,Nummerplade,dato,kilometre)
--values ('Brian','Nanayakkara','BS41416','2018-09-19','156');

select * from Registrering