
//Задачи на формирование массивов:
//сформировать квадратную матрицу порядка n по заданному образцу.
//(Формула: Aij = i * n + j + 1)

namespace _0101_ПР5_2_12
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Введите натуральное число порядка матрицы n: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0) // проверка n
                {
                    break;
                }
                Console.Write("Ошибка: некоррекнтый ввод. Введите ещё раз: ");
            }

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i * n + j + 1;
                }
            }

            Console.WriteLine("\nСформированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}