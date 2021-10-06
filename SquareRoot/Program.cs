using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqrt = 0;
            Console.WriteLine("Please enter a number to be square rooted");

            try
            {
                double inpNum = Convert.ToDouble(Console.ReadLine());
                if(inpNum < 0)
                {
                    throw new InvalidOperationException("Cannot Square root a negative.");
                }
                sqrt = Math.Sqrt(inpNum);
            }catch(Exception e)
            {
                sqrt = 0;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"The square root is {sqrt}");
            }
        }
    }
}
