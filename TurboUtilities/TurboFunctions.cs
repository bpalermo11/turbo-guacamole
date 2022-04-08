using System;

namespace TurboUtilities
{
    public class StringFunctions
    {
        public string Reverse(string s)
        {
            char[] charArray = s.ToUpper().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
