using System;

namespace TaskPerformance
{

    class ComputeAverageApp
    {

        static void Main()
        {
            Console.WriteLine("Enter 5 grades separated by new line:");
            int inPut1 = Convert.ToInt32(Console.ReadLine());
            int inPut2 = Convert.ToInt32(Console.ReadLine());
            int inPut3 = Convert.ToInt32(Console.ReadLine());
            int inPut4 = Convert.ToInt32(Console.ReadLine());
            int inPut5 = Convert.ToInt32(Console.ReadLine());

            double AveRage = inPut1 + inPut2 + inPut3 + inPut4 + inPut5;
            double AveRage2 = AveRage / 5 ;
            int TotalAve = (int)Math.Round(AveRage2);
            Console.WriteLine("The avarage is " + AveRage2 + " and round off to " + TotalAve);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}