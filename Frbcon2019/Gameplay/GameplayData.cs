namespace Frbcon2019
{
    public class GameplayData
    {
        public int CurrentScore { get; set; }
        public int LivesLeft { get; set; }
        public LastMinigameResult LastMinigameResult { get; set; }

        public void Reset()
        {
            LastMinigameResult = LastMinigameResult.None;
            CurrentScore = 0;
            LivesLeft = 3; // TODO: Move this to configuration somewhere
        }
    }
}