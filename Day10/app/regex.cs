using System;
 using System.Text.RegularExpressions;


// ISMATCH
// class Main2
// {
    
//     public static void main2()
//     {

// string text = "Hello123";
// string pattern=@"Hello123";
// // bool result = Regex.IsMatch(text, @"\d+");
// bool result = Regex.IsMatch(text, pattern);

// Console.WriteLine(result); 

//     }
// }

//Match


// class Main3
// {
    
//     public static void main3()
//     {


// // string text = "My age is 21";
// // string text="10A20b30c40d!@_";
// // string text="file.txt";
// string text="Hello this i me Hello";
// // string text="?C:\abc\file.txt";
// // string pattern = @"My age is 21";
// // string pattern = @"\.txt";
// // string pattern = @"\.?";
// string pattern = @"^Hello.*Hello$";
// // string pattern = @"^Hello$";
// // Match m = Regex.Match(text, @"\d+");
// // Match m = Regex.Match(text, pattern);

// // Console.WriteLine(m.Value); 
// Console.WriteLine(Regex.IsMatch(text,pattern)); 
// Console.WriteLine(Regex.Match(text,pattern)); 


//     }
// }



// split 

// class Main4
// {
    
//     public static void main4()
//     {

// string text = "apple,banana;orange, jgcg";
// string[] result = Regex.Split(text, "[,]");

// foreach (string s in result)
// {
//     Console.WriteLine(s);
// }
//     }
// }

// groups




// named group using matches 

// class Main5
// {
//     public static void main5()
//     {
//         string input2 = "1992-02-23 1990-01-01";

//         string pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";

//         MatchCollection matches = Regex.Matches(input2, pattern);

//         foreach (Match m in matches)
//         {  Console.WriteLine(m.Groups["date"].Value);
//             Console.WriteLine(m.Groups["month"].Value);
//             Console.WriteLine(m.Groups["year"].Value);
            
//         }
//     }
// }


// name group using match 


// class Main6
// {
//     public static void main6()
//     {
//         string input = "23-02-1992";

//         string pattern = @"(?<date>\d{2})-(?<month>\d{2})-(?<year>\d{4})";

//         Match m = Regex.Match(input, pattern);

//         Console.WriteLine("Date  : " + m.Groups["date"].Value);
//         Console.WriteLine("Month : " + m.Groups["month"].Value);
//         Console.WriteLine("Year  : " + m.Groups["year"].Value);
//     }
// }


// Group using match

class Main7
{
    public static void main7()
    {
        string input = "23-02-1992";
        string pattern = @"(\d{2})-(\d{2})-(\d{4})";

        Match m = Regex.Match(input, pattern);

        Console.WriteLine(m.Groups[1].Value); 
        Console.WriteLine(m.Groups[2].Value); 
        Console.WriteLine(m.Groups[3].Value); 
    }
}
