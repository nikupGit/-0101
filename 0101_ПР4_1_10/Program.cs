//При написании программы использовать перехват и обработку всех возможных исключений,
//а также генерацию исключения с помощью оператора throw.

//Проверять выполнение программ в режиме контроля переполнения
//и при выключенном данном режиме.
//Составить программу для вычисления значений функции F(x) на отрезке [a, b] с шагом h.
//Результат представить в виде таблицы,
//первый столбец которой – значения аргумента, второй, соответствующие значения функции. 
//F(x) = 3*(x^3)^1/2 + ctg(1/x)


namespace _0101_ПР4_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a;
                Console.Write("Введите начало отрезка (a): ");
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Некорректный формат числа для a");
                }

                double b;
                Console.Write("Введите конец отрезка (b): ");
                try
                {
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Некорректный формат числа для b");
                }

                double h;
                Console.Write("Введите шаг (h): ");
                try
                {
                    h = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Некорректный формат числа для h");
                }

                if (a > b) throw new ArgumentException("a должно быть меньше или равно b");
                if (h <= 0) throw new ArgumentException("h должно быть положительным");

                Console.WriteLine("F(x) = 3*(x^3)^1/2 + ctg(1/x)");
                Console.WriteLine("Таблица значений функции F(x):");
                Console.WriteLine("{0,10} | {1,14}", "x", "F(x)");

                for (double x = a; x <= b; x += h)
                {
                    try
                    {
                        // вычисление значения функции
                        double result;
                        checked
                        {
                            if (x == 0)
                                throw new ArithmeticException("x не может быть 0");

                            try
                            {
                                double s1 = 3 * Math.Sqrt(Math.Pow(x, 3));
                                double s2 = 1 / Math.Tan(1 / x);
                                result = s1 + s2;// F(x) = 3*(x^3)^1/2 + ctg(1/x)
                            }
                            catch (DivideByZeroException)
                            {
                                throw new ArithmeticException("Деление на ноль");
                            }

                            if (double.IsNaN(result))
                                throw new ArithmeticException("Неопределенный результат");

                            if (double.IsInfinity(result))
                                throw new ArithmeticException("Переполнение");
                        }

                        Console.WriteLine("{0,10:f4} | {1,14:f4}", x, result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0,10:f4} | {1,14}", x, ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nПрограмма завершена");
            }
        }
    }
}
