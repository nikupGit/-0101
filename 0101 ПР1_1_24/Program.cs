namespace _0101_ПР1_1_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Формула вычисления решения
            Console.WriteLine("\nРешение (B + sin^2(PI^4))/(cos(2) + |ctg(y)|)\n");

            // Ввод неизвестных значений пользователем
            Console.WriteLine("Введите Beta: ");
            double Beta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Упрощение элементов вычисления
            double PI_4 = Math.Pow(Math.PI, 4);
            double sin_2_PI_4 = Math.Pow(Math.Sin(PI_4), 2);

            double ctg_y = 1 / Math.Tan(y);
            double abs_ctg_y = Math.Abs(ctg_y);

            // Нахождение числителя и знаменателя
            double numerator = Beta + sin_2_PI_4;
            double denominator = Math.Cos(2) + abs_ctg_y;

            // Конечный результат
            if (denominator == 0)
            {
                Console.WriteLine("Ошибка! Занменатель равен нулю.");
            }
            else
            {
                double result = numerator / denominator;
                Console.WriteLine("Финальный результат (10 знаков после запятой): {0:f10}", result);
            }
        }
    }
}
