using System;
using System.Text.RegularExpressions;

namespace LogProcessing{
public class LogParser
{
   private readonly string validLineRegexPattern;
 private readonly string splitLineRegexPattern;
  private readonly string quotedPasswordRegexPattern ;
 private readonly string endOfLineRegexPattern;
     private readonly string  weakPasswordRegexPattern;


public bool IsValidLine(string text)
        {
             string pattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
            if(Regex.IsMatch(text, pattern))
                {
                return false;}
            else
            {
                return true;}}
            
            
public string[] SplitLogLine(string text)
        {
            
        string pattern = @"<\*\*\*>|<====>|<\^\^>";
        string[] ans=Regex.Split(text, pattern);
        return ans;

        }

        public int CountQuotedPasswords(string lines)
        {
            string text = "He said \"password\" and then \"Password\" again but not password.";
               string pattern = "\"password\"";
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        return matches.Count;
            
        }
      
            public string RemoveEndOfLineText(string line)
        {
             string pattern = @"end-of-line\d+$";
        return Regex.Replace(line, pattern, "");
        }
public string[] ListLinesWithPasswords(string[] lines)
        {
             string[] result = new string[lines.Length];

        string pattern = @"\b(password[a-zA-Z0-9]+)\b";

        for (int i = 0; i < lines.Length; i++)
        {
            Match m = Regex.Match(lines[i], pattern, RegexOptions.IgnoreCase);

            if (m.Success)
            {
                result[i] = m.Value + " : " + lines[i];
            }
            else
            {
                result[i] = "-------- : " + lines[i];
            }
        }

        return result;
            
        }


}

}