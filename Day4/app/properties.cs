using System;

class Student
{
    private string name;
    private int age;
     private int marks;
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty");
        }
    } 

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age must be greater than 0");
        }
    }
    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
            else
                Console.WriteLine("Marks must be between 0 and 100");
        }
    }
}

class An
{    public static void Ea()
    {
        Student s1 = new Student();

        s1.Name = "Navneet";
        s1.Age = 22;
        s1.Marks = 85;

        Console.WriteLine("Student Details");
        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
        Console.WriteLine("Marks: " + s1.Marks);
    }
}
