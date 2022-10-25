namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введiть ваш нiкнейм :");
            string? nickname1 = Console.ReadLine();
            Console.WriteLine("\nВведiть нiкнейм опонента :");
            string? nickname2 = Console.ReadLine();
            Console.WriteLine("\nВведiть початковий рейтинг :");
            int initialrating = Convert.ToInt16(Console.ReadLine());
            var acc1 = new GameAccount(nickname1!, initialrating);
            var acc2 = new GameAccount(nickname2!, initialrating);
            Console.WriteLine("\nСкiльки iгор бажаєте провести :");
            int gamescount = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < gamescount; i++)
            {
                Random random = new Random();
                int n = random.Next(0, 2);
                Console.WriteLine("\nНа скiльки рейтингу граєте :");
                int bid = Convert.ToInt16(Console.ReadLine());
                if (n == 0)
                {
                    acc1.WinGame(nickname1!, nickname2!, bid);
                    acc2.LoseGame(nickname2!, nickname1!, bid);
                }
                else
                {
                    acc1.LoseGame(nickname1!, nickname2!, bid);
                    acc2.WinGame(nickname2!, nickname1!, bid);
                }
            }
            Console.WriteLine($"\nСТАТИСТИКА ГРАВЦЯ {nickname1!} :\n");
            Console.WriteLine(acc1.GetStats());
            Console.WriteLine($"\nСТАТИСТИКА ГРАВЦЯ {nickname2!} :\n");
            Console.WriteLine(acc2.GetStats());
        }
    }
}