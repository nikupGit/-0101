//Найти сумму всех n-значных чисел (1<=n<=4). 


namespace _0101_ПР3_3_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n (1 <= n <= 4)");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            bool check = true;
            switch (n)
            {
                case 1: for (int i = 1; i <= 9; i++) { sum += i; } break;
                case 2: for (int i = 10; i <= 99; i++) { sum += i; } break;
                case 3: for (int i = 100; i <= 999; i++) { sum += i; } break;
                case 4: for (int i = 1000; i <= 9999; i++) { sum += i; } break;
                default: Console.WriteLine("Число выходит за диапазон (1 <= n <= 4)"); check = false; break;
            }
            if (check == true)
            {
                Console.WriteLine("Сумма {0:d}-значных чисел равна: {1:d}", n, sum);
            }
        }
    }
}