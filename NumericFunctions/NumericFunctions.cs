using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumericFunctions
{
    public class NumericFunctions
    {
        public int Add(int n)
        {
            int sum = 0;
            for(int i = 1; i <=n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int Subtract(int x, int y)
        { 
            return x - y;
        }
        public int Multiply(int x, int y) 
        { 
            return x * y;
        }
        public float Divide(int x, float y)
        { 
           return x / y;
        }
        public int Max(int x,int y)
        {
            return (int)Math.Max(x, y);
        }
        public int Min(int x,int y) 
        { 
            return (int)Math.Min(x, y);
        }
        public bool Even(int x)
        {
            if( x % 2 == 0)
                return true;
            else
                return false;
        }
        public bool Odd(int x)
        {
            if (x % 2 != 0)
                return true;
            else
                return false;
        }
        public bool Prime(int x)
        {
            int i;
            for (i = 2; i <= x / 2; i++)
            {
                if (x % i != 0)
                    continue;
                else
                    return true;
            }
            return false;
        }
    }
}