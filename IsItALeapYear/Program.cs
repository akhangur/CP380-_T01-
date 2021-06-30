using System;

namespace IsItALeapYear
{
 public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Boolean IsItALeapYear (int n)
        {
            if(n%4==0)
            {
                if(n%100==0)
                {
                    if(n%400==0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
