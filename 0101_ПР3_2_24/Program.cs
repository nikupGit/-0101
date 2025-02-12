//Составить программу для вычисления значений функции F(x) на отрезке [a, b] с шагом h.
//Результат представить в виде таблицы,
//первый столбец которой – значения аргумента, второй, соответствующие значения функции. 
//F(x) = ctg(x/3) + (1/2)*sin(x)


namespace _0101_ПР3_2_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало отрезка (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конец отрезка (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг (h): ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nF(x) = ctg(x/3) + (1/2)*sin(x)");
            Console.WriteLine("Таблица значений функции F(x):");
            Console.WriteLine("{0,10} {1,14}", "x", "F(x)");

            for (double x = a; x <= b; x += h)
            {
                double y = 1 / Math.Tan(x / 3) + 0.5 * Math.Sin(x);
                Console.WriteLine("{0,10:f4} {1,14:f4}", x, y);
            }
        }
    }
}