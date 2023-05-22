using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    class Calculator
    {
        public static double PerformOperation(double num1, double num2, string op)
        {
            double result = double.NaN;


            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":

                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;

                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("К.А.Л.Ь.К.У.Л.Я.Т.О.Р\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;


                Console.Write("Введите первое число и нажмите Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Это недопустимый ввод. Пожалуйста, введите целое число: ");
                    numInput1 = Console.ReadLine();
                }


                Console.Write("Введите второе число и нажмите Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Это недопустимый ввод. Пожалуйста, введите целое число: ");
                    numInput2 = Console.ReadLine();
                }


                Console.WriteLine("Выберите оператора из следующего списка:");
                Console.WriteLine("\t+ - Сложить");
                Console.WriteLine("\t- - Вычесть");
                Console.WriteLine("\t* - Умножить");
                Console.WriteLine("\t/ - Деление");
                Console.Write("Ваш вариант? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.PerformOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Эта операция приведет к математической ошибке.\n");
                    }
                    else Console.WriteLine("Ваш результат: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("О, нет! Исключение при попытке выполнить математические операции.\n - Подробности: " + e.Message);
                }

                Console.WriteLine("------------------------\n");


                Console.Write("Нажмите «n», чтобы выйти или Enter, чтобы продолжить: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }

    }
}