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
        void OnButtonInstanceClickTunnel (FlatRedBall.Gui.IWindow window) 
        {
            if (this.ButtonInstanceClick != null)
            {
                ButtonInstanceClick(window);
            }
        }
    }
}
