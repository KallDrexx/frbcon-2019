using System;
using System.Collections.Generic;
using System.Linq;

namespace Frbcon2019.GumRuntimes
{
    public partial class BabyMeterRuntime
    {
        partial void CustomInitialize()
        {
            foreach(var bar in ContainerInstance.Children)
            {
                if (bar is SpriteRuntime barSprite)
                {
                    barSprite.Visible = false;
                }
            }
        }

        private int _percentage = -1;
        public int Percentage
        {
            get { return _percentage; }
            set
            {
                if (_percentage != value)
                {
                    _percentage = value;

                    UpdateVisibility();
                }
            }
        }

        private void UpdateVisibility()
        {
            var totalBars = ContainerInstance.Children.Count;

            if (totalBars == 0)
            {
                return;
            }

            var percentagePerBar = (1.0f / totalBars) * 100f;
            var visibleBarsCount = (int)(Percentage / percentagePerBar);
            
            for (int x = 0; x < totalBars; ++x)
            {
                var bar = ContainerInstance.Children[x];

                if (bar is SpriteRuntime barSprite)
                {
                    if (x < visibleBarsCount)
                    {
                        barSprite.Visible = true;
                    }
                    else
                    {
                        barSprite.Visible = false;
                    }
                }
            }   
        }
    }
}
