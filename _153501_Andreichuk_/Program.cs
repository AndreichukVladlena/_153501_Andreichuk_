using System;

namespace _153501_Andreichuk_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите делимое : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите делитель : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a / b;
            Console.Write("\nЧастное : " + c);
            Console.ReadKey();
        }
    }
}


