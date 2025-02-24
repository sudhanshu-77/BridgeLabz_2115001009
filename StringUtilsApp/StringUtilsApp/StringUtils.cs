using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringUtilsApp
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            return str.ToUpper();
        }
    }
}
