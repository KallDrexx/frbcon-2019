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
using FlatRedBall.Graphics;

namespace Frbcon2019.Entities.BabyCatcher
{
    public partial class Trash
    {
        public bool Blinking { get; private set; } = false;

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
            Blink();
        }

        private void CustomDestroy()
        {


        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        public void FadeAway()
        {
            SpriteInstance.AlphaRate = -.25f;
        }

        public void StartBlinking()
        {
            Blinking = true;
            CurrentFlashState = Flash.On;
        }

        public void StopBlinking()
        {
            Blinking = false;
            CurrentFlashState = Flash.Off;
        }

        bool waiting = false;
        public void Blink()
        {
            if (Blinking && !waiting) {
                waiting = true;

                if (this.CurrentFlashState == Flash.Off)
                {
                    this.Call(() => {
                        this.CurrentFlashState = Flash.On;
                        this.waiting = false;
                    }).After(TimeSpan.FromMilliseconds(125).TotalSeconds);
                }
                else
                {
                    this.Call(() => {
                        this.CurrentFlashState = Flash.Off;
                        this.waiting = false;
                    }).After(TimeSpan.FromMilliseconds(250).TotalSeconds);
                }
            }
        }
    }
}
