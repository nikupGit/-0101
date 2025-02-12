// В заданном массиве N*N найти сумму элементов в каждой строке.

namespace _0101_ПР6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите порядок матрицы: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[N, N];
            int[] sum_str_arr = new int[N];  // массив для суммы каждой строки

            Random rnd = new Random(); // без сида
            Console.WriteLine("Матрица N*N: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                    Console.Write(arr[i, j] + "\t");
                    sum_str_arr[i] += arr[i, j]; // счет суммы i строки
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМассив суммы каждой строки матрицы: ");
            foreach (int sum in sum_str_arr)
            {
                Console.Write(sum + "\t");
            }
        }
    }
}
