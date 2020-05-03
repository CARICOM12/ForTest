using System;

namespace ForTest
{
    /*На вход поступает число
    Надо вывести все целые числа от 0 
    до этого числа - если это число > 0, 
    иначе - сообщение "число меньше ноля"

    5
    0 1 2 3 4 5
    -5
    Число меньше ноля */

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
            {
                for(int i = 0; i <= number; i++)
                {
                    Console.Write(i + " ");
                }
            }

            else
            {
                Console.Write("The number is less than zero");
            }


        }
    }
}
