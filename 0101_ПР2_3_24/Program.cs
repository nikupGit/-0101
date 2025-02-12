//Составить программу для определения подходящего возраста кандидатуры для вступления
//в брак, используя следующие соображения: возраст девушки равен половине возраста
//мужчины плюс 7, возраст мужчины равен удвоенному возрасту девушки минус 14.


namespace _0101_ПР2_3_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст девушки: ");
            int age_female = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст мужчины: ");
            int age_male = Convert.ToInt32(Console.ReadLine());

            bool female_check = age_male / 2 + 7 == age_female;
            bool male_check = age_female * 2 - 14 == age_male;
            bool min_age_check = age_female >= 16;
            bool check = male_check && female_check && min_age_check;

            switch (check)
            {
                case true: Console.WriteLine("Возраст подходящий"); break;
                case false: Console.WriteLine("Возраст неподходящий"); break;
            }
        }
    }
}
