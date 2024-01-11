using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumericFunctions
{
    public class NumericFunctions
    {
        int Add(int n)
        {
            int sum = 0;
            for(int i = 1; i <=n; i++)
            {
                sum += i;
            }
            return sum;
        }
        int Subtract(int x, int y)
        { 
            return x - y;
        }
        int Multiply(int x, int y) 
        { 
            return x * y;
        }
        float Divide(int x, float y)
        { 
           return x / y;
        }
        int Max(int x,int y)
        {
            return (int)Math.Max(x, y);
        }
        int Min(int x,int y) 
        { 
            return (int)Math.Min(x, y);
        }
        bool Even(int x)
        {
            if( x % 2 == 0)
                return true;
            else
                return false;
        }
        bool Odd(int x)
        {
            if (x % 2 != 0)
                return true;
            else
                return false;
        }
        bool Prime(int x)
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