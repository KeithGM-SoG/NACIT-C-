create database nacit;
Use nacit;

create table students (
email varchar (50) primary key,
fname varchar (50),
lname varchar (50)
);

create table subjects (
subjectId char(4) primary key,
subjectname varchar (50));

create table grades (
gradeId int auto_increment primary key,
email varchar (50),
subjectId char(4),
foreign key (email) references students(email) ,
foreign key (subjectId) references subjects(subjectId));

insert into teacher values 
("Violet","Bandakatatu"),
("Valentino","Fungo"),
("Keith","boondocks");


