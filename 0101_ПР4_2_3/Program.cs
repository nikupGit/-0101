//При написании программы использовать перехват и обработку всех возможных исключений,
//а также генерацию исключения с помощью оператора throw.

//Вычислить и вывести на экран в виде таблицы значения функции,
//заданной с помощью ряда Тейлора,
//на интервале от хнач до хкон с шагом dx с заданной точностью ε.
//Таблицу снабдить заголовком и шапкой.
//Каждая строка таблицы должна содержать значение аргумента,
//значение функции и количество просуммированных членов ряда.
//ln(x) = 2 * Σ [ ((x-1)^(2n+1)) / ((2n+1)*(x+1)^(2n+1)) ], n=0 до ∞


namespace _0101_ПР4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление ln(x) через ряд Тейлора");
            Console.WriteLine("Формула: ln(x) = 2 * Σ [ ((x-1)^(2n+1)) / ((2n+1)*(x+1)^(2n+1)) ], n=0 до ∞\n");

            try
            {
                Console.Write("Введите начальное значение x (x>0): ");
                double xStart = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите конечное значение x: ");
                double xEnd = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите шаг dx (dx>0): ");
                double dx = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите точность ε (0 < ε <=1): ");
                double epsilon = Convert.ToDouble(Console.ReadLine());

                if (xStart <= 0) throw new ArgumentException("Начальное x должно быть > 0");
                if (dx <= 0) throw new ArgumentException("Шаг dx должен быть > 0");
                if (epsilon <= 0 || epsilon > 1) throw new ArgumentException("Точность ε должна быть > 0 или <= 1");
                if (xEnd < xStart) throw new ArgumentException("Конечное x должно быть >= начального");

                Console.WriteLine("\n{0,10} | {1,15} | {2,10}", "x", "ln(x)", "Итераций");
                for (double x = xStart; x <= xEnd; x += dx) // цикл для обхода значений x от xStart до xEnd с шагом dx
                {
                    try
                    {
                        if (x <= 0) throw new ArgumentException("x <= 0");

                        double t = Math.Pow((x - 1) / (x + 1), 2); // вычисление вспомогательной переменной t = ((x - 1) / (x + 1))^2

                        // вычисление первого члена ряда
                        double term = 2 * (x - 1) / (x + 1);
                        double sum = term; // начальное значение суммы ряда
                        int count = 1;     // количество просуммированных членов ряда
                        int n = 0;         // текущий индекс члена ряда

                        while (Math.Abs(term) >= epsilon) // цикл для вычисления суммы ряда с заданной точностью ε
                        {
                            n++;
                            term *= t * (2 * n - 1) / (2 * n + 1);
                            sum += term;
                            count++;

                            if (count > 1000000) // защита от бесконечного цикла
                                throw new Exception("Превышено максимальное число итераций");
                        }
                        Console.WriteLine("{0,10:F4} | {1,15:F10} | {2,10}", x, sum, count); // вывод результата для текущего x
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0,10:F4} | {1,15} | {2,10}", x, ex.Message, "N/A"); // обработка ошибок для текущего x
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}"); // обработка ошибок ввода данных
            }
            finally
            {
                Console.WriteLine("\nПрограмма завершена");
            }
        }
    }
}