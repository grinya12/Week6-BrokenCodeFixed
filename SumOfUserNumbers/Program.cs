using System;

namespace SumOfUserNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Сумма трех чисел
            //приложение предлагает пользователю ввести три числа и выводит на экран их сумму
            //исправленный до рабочего состояния код дает до 5 пунктов 

            int sum = 0;

            Console.WriteLine("Enter three numbers and find out the sum");
            Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;   
            }

            Console.WriteLine($"Total:{sum}");
            Console.WriteLine(" ");
            
            Console.WriteLine("Have a nice day!");
            
        }
    }
}
