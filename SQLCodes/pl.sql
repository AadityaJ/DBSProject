/*firstly construct password feild differently*/
create table admin_pass_ (admin_id varchar2(15),password varchar2(15));
insert into admin_pass_ values('1000','abcd');
insert into admin_pass_ values('1001','qaz');
insert into admin_pass_ values('1002','wsx');
/* create log table*/
create table admin_log_ (admin_id varchar2(15),dt date);
/* now procedure-sql*/
/* add entry to table whenever admin logs in */
create or replace procedure logger (admin_id in varchar2,dt in varchar2)
is res number;
BEGIN
	insert into admin_log_ values(admin_id,dt);
End;
/ 
