using System;

namespace GradeCalculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Welcome The Grade Calculator");
            Console.WriteLine("Please Enter The Mid-Term Grade");
            double midterm = double.Parse(Console.ReadLine()); //%30
            Console.WriteLine("Please Enter The First Quiz Grade");
            double quiz = double.Parse(Console.ReadLine()); //%15
            Console.WriteLine("Please Enter The Second Quiz Grade");
            double quiz2 = double.Parse(Console.ReadLine());  //%15
            Console.WriteLine("Please Enter The Final Note");
            double final = double.Parse(Console.ReadLine()); //%40
            total = (midterm * 0.3) + (quiz * 0.15) + (quiz2 * 0.15) + (final * 0.4);
            if (total >= 85 && total <= 100)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: AA ");
            }
            else if(total >= 75 && total <= 84)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: BA ");
            }
            else if(total >= 65  && total <= 74)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: BB ");
            }
            else if(total >= 55 && total <= 64)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: CC ");
            }
            else if(total >= 45 && total <= 54)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: DC ");
            }
            else if(total >= 35 && total <= 44)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: DD ");
            }
            else if(total >= 25 && total <= 34)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: FD ");
            }
            else if(total >= 1 && total <= 24)
            {
                Console.WriteLine("Your Average:" + total + "Your Grade: FF ");
            }
            else
            {
                Console.WriteLine("Please Enter A Valid Value!");
            }
                    


        }
    }
}
