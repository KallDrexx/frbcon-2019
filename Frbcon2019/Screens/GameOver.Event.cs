namespace Frbcon2019.Screens
{
    public partial class GameOver
    {
        void OnPlayAgainButtonClick (FlatRedBall.Gui.IWindow window)
        {
            GlobalData.GameplayData.Reset();
            MoveToScreen(typeof(Scoreboard));
        }
    }
}
