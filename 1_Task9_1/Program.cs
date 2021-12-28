using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int operacia;
            bool shetchik1 = true;
            bool shetchik2 = true;


            Console.Write("первое число = ");
            string proverka1 = Console.ReadLine();
            if (Int32.TryParse(proverka1, out int result1))
            {
                firstNumber = result1;
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных");
                shetchik1 = false;

            }
            if (shetchik1 == true)
            {

                Console.Write("второе число = ");
                string proverka2 = Console.ReadLine();
                if (Int32.TryParse(proverka2, out int result2))
                {
                    secondNumber = result2;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод данных");
                    shetchik2 = false;

                }

                if (shetchik2 == true)
                {
                    Console.Write("код операции (1 = +, 2 = -, 3 = /, 4 = *) = ");
                    operacia = Convert.ToInt32(Console.ReadLine());

                    switch (operacia)
                    {
                        case 1:
                            {
                                Console.WriteLine("Ответ = {0}", firstNumber + secondNumber);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Ответ = {0}", firstNumber - secondNumber);
                                break;
                            }
                        case 3:
                            {
                                if (secondNumber != 0)
                                {
                                    Console.WriteLine("Ответ = {0}", (double)firstNumber / secondNumber);

                                }
                                else
                                {
                                    Console.WriteLine("На ноль делить нельзя");
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Ответ = {0}", firstNumber * secondNumber);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Введен несуществующий номер операции");
                                break;
                            }
                    }


                }

            }
            Console.ReadLine();

    }   }
}
