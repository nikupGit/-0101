namespace _0101_ПР2_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if (x <= 0)
            {
                y = 0;
                Console.WriteLine("Для x = {0:f}, y = {1:f0}", x, y);
            }

            else if (x > 0 && x <= 1)
            {
                y = x;
                Console.WriteLine("Для x = {0:f}, y = {1:f}", x, y);
            }
            else
            {
                y = Math.Pow(x, 4);
                Console.WriteLine("Для x = {0:f}, y = {1:f}", x, y);
            }
        }
    }
}
