namespace Lab1
{
    public static class Play
    {
        public static void aGame(GameAccount acc1, GameAccount acc2)
        {
            Random random = new Random();
            int n = random.Next(0, 2);
            Console.WriteLine("\nНа скiльки рейтингу граєте :");
            int bid = Convert.ToInt16(Console.ReadLine());
            if (n == 0)
            {
                acc1.WinGame(acc1.UserName, acc2.UserName, bid);
                acc2.LoseGame(acc2.UserName, acc1.UserName, bid);
            }
            else
            {
                acc1.LoseGame(acc1.UserName, acc2.UserName, bid);
                acc2.WinGame(acc2.UserName, acc1.UserName, bid);
            }
        }
    }
}
