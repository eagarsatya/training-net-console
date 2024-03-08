// See https://aka.ms/new-console-template for more information

using TrainingNET.Models;

var listStudents = new List<Student>();
var student1 = new Student
{
    Id = 1,
    Name = "Eagar Satya",
    Age = 30,
    SubjectId = 3,
};

var student2 = new Student
{
    Id = 2,
    Name = "Roberto Wu",
    Age = 40,
    SubjectId = 1,
};

var student3 = new Student
{
    Id = 3,
    Name = "Tie Antono",
    Age = 1000,
    SubjectId = 2,
};

var student4 = new Student();

listStudents.Add(student1);
listStudents.Add(student2);
listStudents.Add(student3);

//var currentRole = "Student";

var query = listStudents.Where(Q => Q.Age >= 50);
//if(currentRole == "Student")
//{
//    query = query.Where(Q => Q.Age < 60);
//}

listStudents.Add(new Student
{
    Id = listStudents.Count + 1,
    Age = 60,
    Name = "Extra Student",
    SubjectId = 1
});

//foreach (var student in query)
//{
//    Console.WriteLine(student.ConcanateIdName());
//}



var listSubject = new List<Subject>();
var mathSubject = new Subject
{
    Id = 1,
    Name = "Math"
};

var csSubject = new Subject
{
    Id = 2,
    Name = "Computer Science"
};

var netSubject = new Subject
{
    Id = 3,
    Name = ".NET Subject"
};

listSubject.Add(mathSubject);
listSubject.Add(csSubject);
listSubject.Add(netSubject);

//Console.WriteLine("Please input student's name : ");
//student4.Name = Console.ReadLine();
//Console.WriteLine("Please input student's age : ");
//student4.Age = Convert.ToInt32(Console.ReadLine());
//student4.Id = listStudents.Count + 1;
//listStudents.Add(student4);


//Linq Lambda
//var oldestStudent = listStudents.OrderBy(Q => Q.Age).Last();
//var oldestStudentOtherWay = listStudents.OrderByDescending(Q => Q.Age).First();

//listStudents = listStudents.Where(Q => Q.Age < 50 && Q.Id == 1).ToList();

//var selectedSubjecIds = new List<int>() { 1, 2 };

////LINQ Query Expression
//var joinedStudentSubject = from student in listStudents
//                           join subject in listSubject on student.SubjectId equals subject.Id
//                           where selectedSubjecIds.Contains(subject.Id) && student.Age > 30
//                           select new
//                                  {
//                                      StudentId = student.Id,
//                                      StudentName = student.Name,
//                                      SubjectName = subject.Name,
//                                  };

////Gua mau nge print yang ambil Subject Math & CS, tapi yang umurnya di atas 30
//foreach (var student in joinedStudentSubject)
//{
//    Console.WriteLine($"{student.StudentId} - {student.StudentName} - {student.SubjectName}");
//}

//foreach (var student in listStudents)
//{
//    Console.WriteLine(student.ConcanateIdName());
//}


//var dateTimeExample = DateTime.UtcNow;
//var dateTimeOffsetExample = DateTimeOffset.UtcNow;

//Console.WriteLine(dateTimeExample);
//Console.WriteLine(dateTimeOffsetExample);

//var dateOnly = new DateOnly(dateTimeExample.Year, dateTimeExample.Month, dateTimeExample.Day);
//var timeOnly = new TimeOnly(dateTimeExample.Hour, dateTimeExample.Minute);

//Console.WriteLine(dateOnly);
//Console.WriteLine(timeOnly);


Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
studentDictionary.Add(student1.Id, student1);
studentDictionary.Add(student2.Id, student2);
studentDictionary.Add(student3.Id, student3);

//var index0Student = studentDictionary[4];

Queue<Student> studentQueue = new Queue<Student>();
studentQueue.Enqueue(student2);
studentQueue.Enqueue(student1);
studentQueue.Enqueue(student3);
studentQueue.Dequeue();

Stack<Student> studentStack = new Stack<Student>();
studentStack.Push(student1);
studentStack.Push(student2);
studentStack.Push(student3);


Console.WriteLine($"Peek : {studentStack.Peek().Id} - {studentStack.Peek().Name}");

foreach (var student in studentStack)
{
    Console.WriteLine($"{student.Id} - {student.Name}");
}


Console.ReadKey();

Console.WriteLine("Halo Andrew");
Console.WriteLine("Ganti Lagi nih");
