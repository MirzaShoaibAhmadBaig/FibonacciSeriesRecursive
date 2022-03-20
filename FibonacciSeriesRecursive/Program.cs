using System;

namespace FibonacciSeriesRecursive
{
    class Program
    {
        static int Firstnum = 0, Secondnum = 1, Final;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Number");
            int UserNum = Int32.Parse(Console.ReadLine());
            FibonacciRecursive(UserNum);

        }

        public static void FibonacciRecursive(int UserNum)
        {
            if(UserNum>0)
            {
                Final = Firstnum + Secondnum;
                Console.WriteLine(Final);
                Firstnum = Secondnum;
                Secondnum = Final;
                FibonacciRecursive(UserNum - 1);



            }




        }
    }
}
