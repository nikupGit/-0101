// Услуги телефонной сети оплачиваются по следующему правилу:
// за разговоры до А минут в месяц – В рублей,
// а разговоры сверх установленной нормы
// оплачиваются из расчета С руб. за минуту.
// Написать программу,
// вычисляющую плату за пользование телефоном
// для введенного времени разговоров за месяц.


namespace _0101_ПР2_2_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите норму минут разговоров в месяц:");
            double A_min_month = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оплату за норму либо меньше разговоров в рублях за месяц за услуги:");
            double B_rub_A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оплату за минуту при превышении нормы:");
            double C_rub_min = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время(минут) пользования за месяц:");
            double minutes = Convert.ToDouble(Console.ReadLine());

            double price;
            if (minutes <= A_min_month)
            {
                price = B_rub_A;
            }
            else
            {
                double extra_minutes = minutes - A_min_month;
                price = B_rub_A + extra_minutes * C_rub_min;
            }
            Console.WriteLine("Итого оплата за услуги: {0:f} рублей.", price); ;
        }
    }
}