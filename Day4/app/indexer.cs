using System;

class StudentCollection{
 private string[] students = new string[3];
    public string this[int index]
    {
        get{
            if (index < 0 || index >= students.Length)
            {
                return "inavlid index";}
            return students[index];
        }
        set{
            if (index >= 0 && index < students.Length){
                students[index] = value;
            }}}}
        
class Inde
{
    public static void Index()
    {
        StudentCollection sc = new StudentCollection();

  
        sc[0] = "Navneet";
        sc[1] = "Ram";
        sc[2] = "Aman";

        Console.WriteLine(sc[0]);
        Console.WriteLine(sc[1]);
        Console.WriteLine(sc[2]);
        Console.WriteLine(sc[5]);
        // returning indexces
    }
}