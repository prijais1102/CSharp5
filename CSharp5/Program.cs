using NumericFunctions;
using StringFunctions;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace ExtensionMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumericFunctions.NumericFunctions numericFunctions = new NumericFunctions.NumericFunctions();
                Console.WriteLine("Enter n to add from 1 to n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(numericFunctions.Add(n));
                StringFunctions.StringFunctions stringFunctions = new StringFunctions.StringFunctions();
                Console.WriteLine("Enter a string to check for palindrome");
                string s = Console.ReadLine();
                Console.WriteLine(stringFunctions.Palindrome(s));
                Program program = new Program();
                Console.WriteLine(numericFunctions.Table(10));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static class ExtendedProgram
    {
        public static string Table(this NumericFunctions.NumericFunctions nm, int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{num} * {i} = {num * i}");
            }
            return sb.ToString();
        }
    }
}


