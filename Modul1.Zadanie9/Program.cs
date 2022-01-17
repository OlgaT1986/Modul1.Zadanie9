using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;                                                       
            int n = 0;
            Console.WriteLine("Добро пожаловать в калькулятор для простых расчетов");
            try                                                                  
            {
                Console.Write("Введите целое число a= ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число b= ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Введенные числа не соответствуют формату", ex.Message);
            }


            #region 
            Console.WriteLine("Выберите код операции- требуемое арифметическое действие:");
            string kod1 = "1 - сложение ";
            Console.WriteLine("{0,20}", kod1);
            string kod2 = "2 - вычитание ";
            Console.WriteLine("{0,21}", kod2);
            string kod3 = "3 - произведение ";
            Console.WriteLine("{0,24}", kod3);
            string kod4 = "4 - деление ";
            Console.WriteLine("{0,19}", kod4);
            #endregion
            n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            double sub = 0;
            double mult = 0;
            float div = 0;
            switch (n)

            {
                case 1:
                    {
                        sum = a + b;
                        Console.WriteLine("Ваш выбор 1 - сложение: ");
                        Console.WriteLine("Сумма чисел составляет = {0}", sum);
                        break;
                    }
                case 2:
                    {
                        sub = a - b;
                        Console.WriteLine("Ваш выбор 2 - вычитание: ");
                        Console.WriteLine("Разность чисел составляет = {0}", sub);
                        break;
                    }
                case 3:
                    {
                        mult = a * b;
                        Console.WriteLine("Ваш выбор 3 - произведение: ");
                        Console.WriteLine("Произведение чисел составляет {0}", mult);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Ваш выбор 4 - деление: ");
                        if (b == 0)
                        {
                            Console.WriteLine("Ошибка! Деление на 0 невозможно!");
                        }
                        else
                        {
                            Console.WriteLine("Отношение чисел составляет = {0:0.00}", div = a / b);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка! Не выбрана операция с указанным номером");
                        Console.ReadKey();
                        return;
                    }
            }
            Console.WriteLine();
            Console.Write("Для завершения работы нажмите любую клавишу на клавиатуре");
            Console.ReadKey();

        }
    }
}

