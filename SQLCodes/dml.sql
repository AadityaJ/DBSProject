create table user_(name varchar(15),u_id varchar(15) not null,ph_no varchar(15),
	address varchar2(45),dob date,age int,password varchar(15) not null, primary key(u_id));

create table admin_(name varchar(15),admin_id varchar(15) not null,password varchar(15) not null,ph_no varchar(15),primary key(admin_id));