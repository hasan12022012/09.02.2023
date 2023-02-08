using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.FullName = "Samir Karimov";
            emp1.Salary = 300;

            
            Console.WriteLine("Muhendislerin sayi:");
            int count = Convert.ToInt32(Console.ReadLine());

            Engineer[] engineers = new Engineer[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ad daxil edin:");
                string fullname = Console.ReadLine();

                yenidendaxiledin: Console.WriteLine("Gelirini daxil edin:");
                string input = Console.ReadLine();
                var slry = Convert.ToInt32(input);
                if (slry < 1000)
                    goto yenidendaxiledin;

                Console.WriteLine("------------------------------------------------------------------");
                Engineer array = new Engineer { Salary = slry };
                engineers[i] = array;

            }
            double sum = 0;
            for (int i = 0; i < engineers.Length; i++)
            {
                sum += engineers[i].Salary;
            }
            var result = sum / engineers.Length;

            Console.WriteLine(result);

        }



    }
    
}
