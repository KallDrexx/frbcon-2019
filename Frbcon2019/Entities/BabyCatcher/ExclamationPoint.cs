using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;

namespace Frbcon2019.Entities.BabyCatcher
{
	public partial class ExclamationPoint
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{


		}

		private void CustomActivity()
		{

            if (Alpha <= 0.01f)
            {
                Destroy();
            }
		}

		private void CustomDestroy()
		{


		}


        public void FadeAway()
        {
            AlphaRate = -1f;
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
