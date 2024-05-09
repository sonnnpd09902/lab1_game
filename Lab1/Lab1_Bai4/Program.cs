using System;
using System.Collections.Generic;
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();

        studentList.Add(new Student("Alice", 20));
        studentList.Add(new Student("Bob", 22));
        studentList.Add(new Student("Charlie", 21));

        foreach (var student in studentList)
        {
            student.DisplayInfo();
            Console.ReadLine();
        }

    }
}