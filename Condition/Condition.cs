using System;

namespace Condition
{
    public static class Condition
    {   
        public static int Task1(int n)
        {
            if (n>0)
            {
                return n*n;
            }
            if(n<0)
            {
                return Math.Abs(n);
            }
           
                return 0;
           
                

            throw new NotImplementedException();
        }

        public static int Task2(int n)
        {
            int result = 0, digits = 0, temp_n = n;
            while (temp_n > 0)
            {
                temp_n /= 10;
                digits++;
            }

            int[] myNum = new int[digits];
            for (int i = 0; n > 0; n /= 10, i++)
            {
                result = n % 10;
                myNum[i] = result;
            }
            Array.Sort(myNum);
            Array.Reverse(myNum);
            string result_str = string.Join("", myNum);
            result = Int32.Parse(result_str);
            return result;
            throw new NotImplementedException();
        }
    }
}
