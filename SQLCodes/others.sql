insert into user_session_ values('100','1204','12-04-16 11:18:10;','12-04-16 11:18:50',56);
insert into user_session_ values('101','1205','12-04-16 11:18:32;','12-04-16 11:18:51',57);
insert into user_session_ values('102','1206','12-04-16 11:18:45;','12-04-16 11:18:50',09);
insert into user_session_ values('103','1205','12-04-16 11:19:09;','12-04-16 01:28:50',19);
insert into user_session_ values('104','1206','12-04-16 11:30:10;','12-04-16 11:33:50',28);
insert into user_session_ values('105','1209','12-04-16 11:48:32;','12-04-16 11:48:50',56);
insert into user_session_ values('106','1208','12-04-16 11:56:10;','12-04-16 11:59:50',98);
insert into user_session_ values('107','1209','12-04-16 12:00:06;','12-04-16 12:18:54',12);
insert into user_session_ values('108','1206','12-04-16 01:00:00;','12-04-16 01:18:50',69);
insert into user_session_ values('109','1204','12-04-16 01:00:10;','12-04-16 03:18:50',96);
/* user session done */
insert into banned_ values('1207','13-APR-16','12-APR-16','1000');
/* 1207 is banned and so is absent*/
insert into renew_ values('10','1204','1000','10-APR-16',100);
insert into renew_ values('11','1209','1001','10-APR-16',100);
insert into renew_ values('12','1205','1000','10-APR-16',300);
insert into renew_ values('13','1206','1001','10-APR-16',100);
insert into renew_ values('14','1208','1002','10-APR-16',100);
/*interleaved_ is the same table*/
insert into interleaved_ values('10','1204',100);
insert into interleaved_ values('11','1209',100);
insert into interleaved_ values('12','1205',300);
insert into interleaved_ values('13','1206',100);
insert into interleaved_ values('14','1208',100);
insert into interleaved_ values('15','1207',10);
/*Done*/

