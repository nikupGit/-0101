// Сформировать массив 8*8, «Шахматная доска»,
// где черный квадрат – еденица, а белый квадрат – ноль.
// Полученную матрицу вывести в явном виде.

namespace _0101_ПР6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 8;
            int[,] chess_board = new int[size, size];

            int k = 0;
            for (int i = 0; i < size; i++)
            {
                k++; // счетчик ряда
                for (int j = 0; j < size; j++)
                {
                    if (k % 2 == 0) // четные ряды
                    {
                        if (j % 2 == 0) chess_board[i, j] = 1; // четные клетки
                        else chess_board[i, j] = 0; // нечетные
                    }
                    else // нечетные ряды
                    {
                        if (j % 2 == 0) chess_board[i, j] = 0; // наоборот
                        else chess_board[i, j] = 1;
                    }
                }
            }
            Console.WriteLine("Массив в виде шахматной доски: ");
            for (int i = 0; i < size;i++)
            {
                for (int j = 0; j < size;j++)
                {
                    Console.Write(" " + chess_board[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
