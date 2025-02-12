// В заданном одномерном массиве найти сумму,
// произведение и количество отрицательных элементов стоящих на нечетных местах.
// Ввод массива организовать с помощью счетчика случайных чисел.

namespace _0101_ПР6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] arr = new int[size];

            Random rnd = new Random(1); // 1 = seed
            for (int i = 0; i < size; i++) arr[i] = rnd.Next(-100, 100);

            Console.WriteLine("Введенный массив: ");
            foreach (int item in arr)
            {
                Console.Write(item + " "); // вывод массива
            }
            // сумма, произведение, количество негативных
            int sum = 0, mult = 1, numb_neg = 0;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    // необходимые операции
                    sum += arr[i];
                    mult *= arr[i];
                    if (arr[i] < 0) numb_neg++;         
                }
            }
            Console.WriteLine("Элементы на нечетных местах.");
            Console.WriteLine("Их сумма: " + sum);
            Console.WriteLine("Их произведение: " + mult);
            Console.WriteLine("Количество отрицательных элементов: " + numb_neg);
        }
    }
}
