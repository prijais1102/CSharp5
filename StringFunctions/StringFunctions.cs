using System.Globalization;
using System.Text.RegularExpressions;

namespace StringFunctions
{
    public class StringFunctions
    {
        public int NoOfCharInSentence(string sentence)
        {

            return sentence.Length;

        }
        public bool Palindrome(string s)
        {
            char[] stringArray = s.ToCharArray();

            Array.Reverse(stringArray);
            string str=new string(stringArray);
            
            if(str.ToString().Equals(s))
            {
                return true;
            }
            return false;
        }
        public string ReverseSentence(string sentence)
        {
            string result = "";

                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    result += sentence[i];
                }
          
          


            return result;

        }
        public void FindAllTypesChar(string sentence)
        {


            int consonants = 0;
            int vowels = 0;
            int integers = 0;
            int special = 0;
            
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] >= 'A' && sentence[i] <= 'Z' || sentence[i] >= 'a' && sentence[i] <= 'z')
                    {
                        if (sentence[i] == 'A' || sentence[i] == 'a' || sentence[i] == 'E' || sentence[i] == 'e'
                            || sentence[i] == 'I' || sentence[i] == 'i' || sentence[i] == 'O' || sentence[i] == 'o' ||
                            sentence[i] == 'U' || sentence[i] == 'u')
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }

                    }
                    if (sentence[i] >= '0' && sentence[i] <= '9')
                    {
                        integers++;
                    }
                    if (sentence[i] == '@' || sentence[i] == ' ' || sentence[i] == '#' || sentence[i] == '$')
                    {
                        special++;
                    }

                }
                Console.WriteLine("No of integers : " + integers);
                Console.WriteLine("No of Vowels : " + vowels);
                Console.WriteLine("No of Consonants : " + consonants);
                Console.WriteLine("No of Special Characters : " + special);
            }
        public string StringToUpper(string sentence)
        {
            return sentence.ToUpper();

        }
        public string StringToProper(string sentence)
        {
            var textinfo = CultureInfo.CurrentCulture.TextInfo;
            return textinfo.ToTitleCase(sentence);

        }
        public string CombineTwoSentences(string sentence1, string sentence2)
        {


            return sentence1 = sentence1 + " " + sentence2;

        }
        public string RemoveExtraSpaces(string sentence)
        {
            return Regex.Replace(sentence, @"\s+", " ").Trim();
        }
        public int CountNoOfWords(string sentence)
        {
           
            int count = 0;
           
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i].Equals(" "))
                    {
                        count++;
                    }

                }
            return count;
        }
        public bool FindSubstring(string sentence, string substring)
        {
            bool temp;
           
                if (sentence.Contains(substring))
                {
                    temp = true;

                }
                else
                {
                    temp = false;
                }
            

            return temp;
        }
        public int NoOfOccurrenceOfSubString(string sentence, string substring)
        {
            int count = 0;
                for (int i = 0; i < sentence.Length - substring.Length + 1; i++)
                {
                    if (sentence.Substring(i, substring.Length) == substring)
                    {
                        count++;
                    }
                }
            
            return count;
        }






















    }


    }

