namespace Lab1
{
    public class Game
    {
        public string Player { get; }
        public string Opponent { get; }
        public int Rating { get; }
        public string Outcome { get; }
        public Game(string player, string opponent, int rating, string outcome)
        {

            Player = player;
            Opponent = opponent;
            Rating = rating;
            Outcome = outcome;
        }
    }
}