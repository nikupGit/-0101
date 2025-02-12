// В заданном массиве 5*5 найти сумму и произведение элементов
// в заданной области, все остальные элементы обнулить.
// Исходную и полученную матрицу вывести в явном виде

namespace _0101_ПР6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int[,] arr = new int[size, size];

            Random rnd = new Random();
            Console.WriteLine("Изначальный массив 5*5: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum_in = 0;
            int mult_in = 1;
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i > j && i + j < size - 1) // область
                    {
                        sum_in += arr[i, j];
                        mult_in *= arr[i, j];
                    }
                    else arr[i, j] = 0;
                }
            }
            Console.WriteLine("\nОбновленный массив: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов в области: {sum_in}");
            Console.WriteLine($"Произведение элементов в области: {mult_in}");
        }
    }
}
