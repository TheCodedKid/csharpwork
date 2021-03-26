using System;
public class StudentTest
{
    public static void Main(string[] args)
    {
        Student.Count = 0;
        Console.WriteLine("Total number of students before instantiation: {0}", Student.Count);
        // Static members exist even when no object is created for the class
        Student e1 = new Student("Susan", "Baker");
        Student e2 = new Student("Bob", "Blue");
        // show that Count is 2 after creating two Employees
        Console.WriteLine("\n Students after instantiation: {0}", Student.Count);
        Console.WriteLine("\n Student 1: {0} {1}\n Student 2: {2} {3}\n",
           e1.FirstName, e1.LastName,
           e2.FirstName, e2.LastName);
        e1.FirstName = "Sam";
        e1 = null; // mark object referenced by e1 as no longer needed
        e2 = null; // mark object referenced by e2 as no longer needed
    }
}