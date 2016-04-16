create table user_(name varchar(15),u_id varchar(15) not null,ph_no varchar(15),
	address varchar2(45),dob date,age int,password varchar(15) not null, primary key(u_id));

create table admin_(name varchar(15),admin_id varchar(15) not null,password varchar(15) not null,
	ph_no varchar(15),primary key(admin_id));
/*                    */
create table user_session_ (session_id varchar2(15) not null,u_id varchar(15),login varchar2(18),
	logout varchar2(18),data_used int,primary key(session_id),foreign key(u_id) references user_(u_id));
/* user session created */
create table banned_ (u_id varchar(15),date_from date,date_to date,admin_id varchar(15),foreign key(u_id) references user_(u_id),
	foreign key(admin_id) references admin_(admin_id));
/* banned created*/
create table renew_ (renew_id varchar(15),u_id varchar(15),admin_id varchar(15),curr_date date,amount int,
	foreign key(u_id) references user_(u_id),foreign key(admin_id) references admin_(admin_id),primary key (renew_id));
/* renew creates */
create table interleaved_ (renew_id varchar(15),u_id varchar(15),amount int,primary key(renew_id));

/* basic dml done*/
create table last_(id varchar(15),table_name varchar(15));
/*last_ is  neeeded on user_, admin_,user_session_,renew_ and inertleaved_*/
alter table user_session_ modify login varchar2(20);
alter table user_session_ modify logout varchar2(20);