using System.Text;

namespace LearnProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money; // Суммая вклада
            float precent;  // Процент (годовой)
            int years; // Срок вклада

            // "Магические числа"
            float convertToPrecent = 100f;
            float monthsInYear = 12f;

            Console.Write("Введите количество денег: ");
            money = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ведите процент вклада: ");
            precent = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ведите срок вклада (кол-во лет): ");
            years = Convert.ToInt32(Console.ReadLine());

            double profitWithCompount = 0, profitWithoutCompount = 0; // Профит

            for (int year = 1; year <= years; year++)
            {
                for (int month = 1; month <= monthsInYear; month++)
                {
                    profitWithCompount += 
                        (money + profitWithCompount) * 
                        (1 + precent / convertToPrecent / monthsInYear) 
                        - money;
                }
                profitWithoutCompount += money * (1 + precent / convertToPrecent) - money;
            }

            Console.WriteLine(money + profitWithoutCompount);
            Console.WriteLine(money + profitWithCompount);

        }
    }
}
