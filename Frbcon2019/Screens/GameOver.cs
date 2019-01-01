namespace Frbcon2019.Screens
{
	public partial class GameOver
	{
		void CustomInitialize()
		{
			FinalScoreValue.Text = GlobalData.GameplayData.CurrentScore + "!";
		}

		void CustomActivity(bool firstTimeCalled)
		{
		}

		void CustomDestroy()
		{
		}

        static void CustomLoadStaticContent(string contentManagerName)
        {
        }
	}
}
