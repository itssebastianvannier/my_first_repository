declare
id number(1);
sub1 number(2);
sub2 number(2);
sub3 number(2);
t_marks number(3);
percent number(2);
begin
id := 1;
while (id < 8)
loop
select subject1, subject2, subject3 into sub1,sub2,sub3 from marks where stu_id = id;
t_marks := sub1+sub2+sub3;
percent := ((t_marks/300)*100);
update marks set total_marks = t_marks, percentage = percent where stu_id = id;
id := id+1;
end loop;
end;
/

declare
update_marks marks%rowtype;
id number(2);
t_marks number(3);
percent number(2);
begin
id := 1;
while (id < 8)
loop
select * into update_marks from marks where stu_id = id;
t_marks := update_marks.subject1+update_marks.subject2+update_marks.subject3;
percent := ((t_marks/300)*100);
update marks set total_marks = t_marks, percentage = percent where stu_id = id;
id := id+1;
end loop;
end;
/
