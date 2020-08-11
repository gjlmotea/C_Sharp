using System;

namespace ConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入體重(kg)");
            string wStr = Console.ReadLine();

            Console.WriteLine("請輸入身高(cm)");
            string hStr = Console.ReadLine();
            
            // You can use float, double, or decimal
            decimal w = decimal.Parse(wStr);
            decimal h = decimal.Parse(hStr);
            decimal hM = h / 100;
            decimal BMI = w / (hM * hM);
            Console.WriteLine("BMI:"+ BMI);

            if (BMI >= 18 && BMI <= 24)
            {
                Console.WriteLine("BMI正常");
            }
            else
            {
                Console.WriteLine("BMI異常");
            }
            Console.Read();


            
        }
    }
}
