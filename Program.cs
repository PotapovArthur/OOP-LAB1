﻿namespace Lab1
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
                Play.aGame(acc1, acc2);
            }
            Console.WriteLine($"\nСТАТИСТИКА ГРАВЦЯ {nickname1!} :\n");
            Console.WriteLine(acc1.GetStats());
            Console.WriteLine($"\nСТАТИСТИКА ГРАВЦЯ {nickname2!} :\n");
            Console.WriteLine(acc2.GetStats());
        }
    }
}