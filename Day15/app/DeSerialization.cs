using System;
using System.IO;
using System.Xml.Serialization;

class Main1
{
    public static void main1()
    {
        User user = new User { Id = 1, Name = "Alice" };

        XmlSerializer serializer = new XmlSerializer(typeof(User));

        using (FileStream fs = new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
            Console.WriteLine("XML Serialized");
        }
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
