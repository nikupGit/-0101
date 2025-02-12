//Дана прямоугольная матрица.
//Найти строку с наибольшей суммой элементов.
//Вывести на печать найденную строку и сумму ее элементов.


namespace _0101_ПР5_3_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

            int maxSum = int.MinValue; // начальное значение для максимальной суммы (минимальное int)
            int maxRowIndex = 0;
  
            for (int i = 0; i < matrix.GetLength(0); i++) // перебор всех строк матрицы. GetLength(0) возвращает количество строк
            {
                int currentSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++) // перебор элементов в строке. GetLength(1) возвращает количество столбцов
                {
                    currentSum += matrix[i, j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRowIndex = i;
                }
            }

            Console.Write("Строка с наибольшей суммой: ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[maxRowIndex, j] + " "); // вывод всех элементов строки с наибольшей суммой
            }
            Console.WriteLine("\nСумма элементов: " + maxSum);
        }
    }
}