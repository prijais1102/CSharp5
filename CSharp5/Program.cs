using NumericFunctions;
using StringFunctions;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System;

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
                //Console.WriteLine(numericFunctions.Table());
                ////Console.WriteLine(numericFunctions.EvenNos(1, 8));
                //Console.WriteLine(numericFunctions.FindPrimeNos());
                //Console.WriteLine(numericFunctions.TableOneToTen());
                Console.WriteLine(numericFunctions.ReverseNumber());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static class ExtendedProgram
    {
        public static string EvenNos(this NumericFunctions.NumericFunctions nm, int startnumber, int endnumber)
        {
            Console.WriteLine("Even numbers in this range-");
            for (int i = startnumber; i <= endnumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return "Even nos are displayed";

        }

        public static string OddNos(this NumericFunctions.NumericFunctions nm, int startnumber, int endnumber)
        {
            Console.WriteLine("Odd numbers in this range");
            for (int i = startnumber; i <= endnumber; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            return "Odd nos are displayed";
        }

        public static string FindPrimeNos(this NumericFunctions.NumericFunctions nm)
        {
            Console.WriteLine("Enter start and end nos.");
            int startno = int.Parse(Console.ReadLine());
            int endno = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("Prime nos within this range-");
            for (int i = startno; i <= endno; i++)
            {
                int prime = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = 1;
                            break;
                        }
                    }
                    if (prime == 0)
                    {
                        Console.WriteLine(i);
                        count++;
                    }
                }

            }
            return "Prime nos are displayed and their count is "+count;
        }


        public static string Table(this NumericFunctions.NumericFunctions nm)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter no. to get it's table");
            int num=int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{num} * {i} = {num * i}");
            }
            return sb.ToString();
        }

        public static string TableOneToTen(this NumericFunctions.NumericFunctions nm)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter range of nos.");
            int start=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());
            for (int j = start; j <= end; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    sb.AppendLine($"{j} * {i} = {j * i}");
                }
            }
            return sb.ToString();
        }
        public static string TableRange(this NumericFunctions.NumericFunctions nm)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter range of nos.");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range of tables");
            int range1=int.Parse(Console.ReadLine());
            int range2=int.Parse(Console.ReadLine());
            for (int j = start; j <= end; j++)
            {
                for (int i = range1; i <= range2; i++)
                {
                    sb.AppendLine($"{j} * {i} = {j * i}");
                }
                
            }
            return sb.ToString();
        }

        public static int ReverseNumber(this NumericFunctions.NumericFunctions nm)
        {
            Console.WriteLine("Enter a no");
            int num=int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int d = num % 10;
                sum = (sum*10) +d;
                num /= 10;

            }
            return sum;
        }

    }
}


