//Даны натуральное число n и действительное число x.
//Вычислить S = sinx + sinsinx + ... + sinsinsinsinsinsinsinsinsinx -> n раз


namespace _0101_ПР3_1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n (количество применений фунции sin к x)");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительное число x");
            double x = Convert.ToDouble(Console.ReadLine());

            double S = 0;
            double currentx = x;

            for (int i = 1; i <= n; i++)
            {
                currentx = Math.Sin(currentx); // sinus за sinus...x(
                S += currentx;
            }
            Console.WriteLine(S);
        }
    }
}