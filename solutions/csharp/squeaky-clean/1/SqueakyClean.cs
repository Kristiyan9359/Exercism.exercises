public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = "";
        bool capitalizeNext = false;
        
        foreach(char ch in identifier)
        {
            
            if(ch == ' ')
            {
                result += '_';
            }
            
            else if(char.IsControl(ch))
            {
                result += "CTRL";
            }
            
            else if(ch == '-')
            {
                capitalizeNext = true;
            }
            
            else if(capitalizeNext)
            {
                result += char.ToUpper(ch);
                capitalizeNext = false;
            }

            else if(!char.IsLetter(ch))
            {
                continue;
            }

            else if (ch >= 'α' && ch <= 'ω')
            {
                continue;
            }
            
            else
            {
                result += ch;
            }
        }
        return result;
    }
}
