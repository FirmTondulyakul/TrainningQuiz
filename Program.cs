using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salary;
            double SumTax;
            double Money;
            double Tax;
            double Net_income = 0;
            Console.Write("Enter your Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
            
            while (true)
            {
                if(Salary > 180001)
                {
                    Tax = 0.15;
                    Money = Salary - 180000;    
                    SumTax = Money * Tax;
                    Net_income += SumTax;
                    Salary -= Money;

                }else if (Salary > 150001)
                {
                    Tax = 0.1;
                    Money = Salary - 150000;
                    SumTax = Money * Tax;
                    Net_income += SumTax;
                    Salary -= Money;
                }
                else if (Salary > 110001)
                {
                    Tax = 0.05;
                    Money = Salary - 110000;
                    SumTax = Money * Tax;
                    Net_income += SumTax;
                    Salary -= Money;
                }
                else
                {
                    Tax = 0;
                    break;
                }
            }
            Console.WriteLine("Net Income: {0}", Net_income);
            Console.ReadKey();
        }
    }
}
