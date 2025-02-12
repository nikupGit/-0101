//Дана последовательность из N чисел.
//Определить значение k, при котором разность минимальна
//|A[1] + A[2] + ... + A[k] - (A[k+1] + ... + A[N])|


namespace _0101_ПР5_1_24
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите последовательность чисел через пробел: ");
            string[] input = Console.ReadLine().Split();
            int[] A = Array.ConvertAll(input, int.Parse);
            int N = A.Length;

            if (N == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int totalSum = 0;
            foreach (int num in A)
                totalSum += num;

            int SumAk = 0; // сумма элементов от A[0] до A[k]
            int minDif = int.MaxValue; // минимальная найденная разность
            int bestK = 0; // оптимальное k, при котором достигается минимальная разность

            for (int i = 0; i < N; i++)
            {
                SumAk += A[i];

                int currentDif = Math.Abs(2 * SumAk - totalSum); // вычисление текущей разности между двумя частями массива:

                if (currentDif < minDif) // если найдена меньшая разность, обновить minDiff и bestK
                {
                    minDif = currentDif;
                    bestK = i + 1;
                }
                else if (currentDif == minDif && (i + 1) < bestK) // если разность равна текущей минимальной, выбрать меньший k
                {
                    bestK = i + 1;
                }
            }
            Console.Write("Значение k при котором разность минимальна: ");
            Console.WriteLine(bestK);
        }
    }
}
