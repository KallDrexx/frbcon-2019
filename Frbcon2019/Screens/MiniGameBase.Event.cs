using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using Frbcon2019.Screens;
namespace Frbcon2019.Screens
{
    public partial class MiniGameBase
    {
        void OnButtonInstanceClick (FlatRedBall.Gui.IWindow window)
        {
            GlobalData.GameplayData.LastMinigameResult = LastMinigameResult.Win;
            MoveToScreen(typeof(Scoreboard));
        }
    }
}
