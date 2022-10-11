Select * from student order by LastName desc, FirstName desc

select * from enrollment

select * from course

select lastname, firstname from student

select firstname, lastname from student where id = 9

update student set LastName = 'zhang', FirstName = 'rui' where  id = 9

insert student(LastName, FirstName, EnrollmentDate) values ('zhang', 'zhi', '2022-10-09 21:41:00.0000000' ) 

delete student where id = 1 