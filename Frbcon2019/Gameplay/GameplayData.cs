namespace Frbcon2019
{
    public class GameplayData
    {
        public int CurrentScore { get; set; }
        public int LivesLeft { get; set; }
        public int MaxLives { get; set; }
        public LastMinigameResult LastMinigameResult { get; set; }

        public void Reset()
        {
            LastMinigameResult = LastMinigameResult.None;
            CurrentScore = 0;
            MaxLives = 3; // TODO: Move this to configuration somewhere
            LivesLeft = MaxLives;
        }
    }
}