using System;

namespace Lab1
{
    public class GameAccount
    {
       private int GamesCount;
       public string AccountID { get; }
       public string UserName { get; set; }
       public int CurrentRating
       {
            get
            {
                int currentrating = 0;
                foreach (var item in allGames)
                {
                    currentrating += item.Rating;

                }
                return currentrating;
            }
       }
        private static int accountNumberSeed = 1234567890;
        public GameAccount(string username, int rating)
        {
            AccountID = accountNumberSeed.ToString();
            accountNumberSeed++;
            UserName = username;
            WinGame(username, username, rating);
        }
        private List<Game> allGames = new List<Game>();
        public void WinGame(string playername, string opponentname, int rating)
        {
            if (rating < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Мiнiмальний рейтинг гравця не може бути менше, нiж 1");
            }
            var gamewon = new Game(playername, opponentname, rating, "ПЕРЕМОГА");
            allGames.Add(gamewon);
        }
        public void LoseGame(string playername, string opponentname, int rating)
        {
            if (CurrentRating - rating < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Мiнiмальний рейтинг гравця : 1");

            }
                if (rating < 0)
                {
                    throw new InvalidOperationException("Рейтинг на який грають не може бути негативним");
                }
                var lostgame = new Game(playername, opponentname, -rating, "ПОРАЗКА");
                allGames.Add(lostgame);
        }
        public string GetStats()
        {
            var report = new System.Text.StringBuilder();
            int currentrating = 0;
            report.AppendLine("Ставка\tПоточний рейтинг\tГравець\t\tОпонент\t\tКiлькiсть зiграних партiй\tПеремога/поразка\tid акаунту");
            foreach (var item in allGames)
            {
                currentrating += item.Rating;
                GamesCount++;
                if (GamesCount - 1 == 0)
                {
                    report.AppendLine($"---\t\t{currentrating}\t\t{item.Player}\t\t---\t\t{GamesCount - 1}\t\t\t\t---\t\t\t{AccountID}");
                }
                else
                {
                    report.AppendLine($"{Math.Abs(item.Rating)}\t\t{currentrating}\t\t{item.Player}\t\t{item.Opponent}\t\t{GamesCount - 1}\t\t\t\t{item.Outcome}");
                }
            }
            return report.ToString();
        }
    }
}