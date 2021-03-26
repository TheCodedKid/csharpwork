using System;
public class Student
{
    public static int Count { get; set; } // auto-implemented property  
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Student(string first, string last)
    {
        FirstName = first;
        LastName = last;
        ++Count; // maintain the static class member Count
        Console.WriteLine("Student constructor: {0} {1}; Count = {2}",
           FirstName, LastName, Count);
    }
}