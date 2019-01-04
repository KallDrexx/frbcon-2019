using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using FlatRedBall.Gui;

namespace Frbcon2019.Screens
{
	public partial class BeefBallGame
	{

		void CustomInitialize()
		{


		}

        void CustomActivity(bool firstTimeCalled)
        {
            if (!GameIsActive)
            {
                return;
            }

            var cursorX = GuiManager.Cursor.WorldXAt(0);
            var cursorY = GuiManager.Cursor.WorldYAt(0);

            PaddleInstance.X = cursorX;
            PaddleInstance.Y = cursorY;


        }

		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
