using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {



        public static void MainWindow()
        {
            Console.Clear();
            Console.WriteLine("To jest kalkulator");
            Console.WriteLine("[1] mnozenie");
            Console.WriteLine("[2] Dzielenie");
            Console.WriteLine("[3] Dodawanie");
            Console.WriteLine("[4] Odejmowanie");
            string wybor = Console.ReadLine();
            int first, second;

            switch (wybor)
            {
                case "1":
                    {
                        LoadData(out first, out second);
                        Console.WriteLine(Calc.Multiplication(first, second));
                    } break;

                case "2":
                    {
                        LoadData(out first, out second);
                        Console.WriteLine("{0:F}", Calc.Devide(first, second));
                    } break;

                case "3":
                    {
                        LoadData(out first, out second);
                        Console.WriteLine(Calc.Add(first, second));
                    }; break;

                case "4":
                    {
                        LoadData(out first, out second);
                        Console.WriteLine(Calc.Substraction(first, second));
                    } break;
                default: break;
            }

        }

        static void LoadData(out int a, out int b)
        {
            Console.WriteLine("Podaj a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = int.Parse(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            MainWindow();
            Console.ReadKey();


        }
    }
        
    
    
}
