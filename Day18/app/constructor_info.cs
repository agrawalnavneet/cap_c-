using System;
using System.Reflection;




//Without parameter constructor
// class Student
// {
//     public string Name;

//     public Student()
//     {
//         Name = "Default Student";
//     }
// }

// class Main7
// {
//     public static void main7()
//     {
//         Type type = typeof(Student);

//         ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);

//         Student s = (Student)ctor.Invoke(null);

//         Console.WriteLine(s.Name);
//     }
// }


//With parameter constructor

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }
}

class Main8{
    public static void main8()
    {
        Type type = typeof(Student);

        ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(string) }  );

        Student s = (Student)ctor.Invoke(new object[] { "Navneet" });

        Console.WriteLine(s.Name);
    }
}
