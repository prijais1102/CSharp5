namespace StringFunctions
{
    public class StringFunctions
    {
        public bool Palindrome(string s)
        {
            char[] stringArray = s.ToCharArray();

            string reverse = "";

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }
            if(reverse.Equals(s))
            {
                return true;
            }
            return false;
        }

    }
}
