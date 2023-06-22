using Exercise3;

Student[] students = new Student[10];
int[] marks = { 20, 45, 86, 68, 62, 71, 91, 78, 59, 63 };
for (int i = 0; i < 10; i++)
{
    students[i] = new Student
    {
        Name = $"student{i + 1}",
        Mark = marks[i],
    };
}

Array.Sort(students);
foreach (Student student in students)
{
    Console.WriteLine($"{student.Name} : {student.Mark}");
}
