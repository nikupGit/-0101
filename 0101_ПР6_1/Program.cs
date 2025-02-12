//В заданном одномерном массиве найти минимальный элемент и его порядковый номер.
namespace _0101_ПР6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int find_min = int.MaxValue; // для поиска минимального 
            int index = 0; // индекс минимального 
            int[] ints = { 9, 8, 7, 4, 5, 6, 7, 8, 9 };

            // цикл поиска
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < find_min)
                {
                    find_min = ints[i];
                    index = i + 1; // счет от 1
                }
            }
            Console.WriteLine($"Минимальный элемент {find_min} под номером {index}");
        }
    }
}
