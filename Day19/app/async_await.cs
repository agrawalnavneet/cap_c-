using System;
using System.IO;
using System.Threading.Tasks;

// class Main4
// {
//     public static async Task main4()
//     {
       
//       async Task<int> GetDataAsync()
//     {
//         await Task.Delay(1000);
//         return 42;
//     }
//      int result = await GetDataAsync();
//         Console.WriteLine("Result: " + result);
// }
// }


class Main5
{
    public static async Task main5(){
        int length = await GetDataAsync();
        Console.WriteLine("Total characters: " + length);
    }
    static async Task<int> GetDataAsync()
    {
        Console.WriteLine("Start reading the file...");
        string content = await File.ReadAllTextAsync("data.txt");

        Console.WriteLine("File content:");
        Console.WriteLine(content);
        Console.WriteLine("End of program");

        return content.Length;
    }
}
