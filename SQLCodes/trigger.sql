/*firstly construct password feild differently*/
create table admin_pass_ (admin_id varchar2(15),password varchar2(15));
insert into admin_pass_ values('1000','abcd');
insert into admin_pass_ values('1001','qaz');
insert into admin_pass_ values('1002','wsx');
/* create log table*/
create table admin_log_ (admin_id varchar2(15),dt date);
/* now trigger-sql*/
create or replace Trigger logger_ After 
ON admin_pass_
For each row
Begin
	insert into admin_log_ values(admin_id,'12-MAR-2014');
End;
/