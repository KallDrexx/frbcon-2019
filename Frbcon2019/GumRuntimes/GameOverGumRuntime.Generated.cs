    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class GameOverGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            SetProperty("TextInstance.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                            TextInstance.Height = 62f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.Text = "Game Over";
                            TextInstance.UseCustomFont = true;
                            TextInstance.Width = 331f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 100f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            ContainerInstance.Height = 46f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ContainerInstance.Width = 257f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ContainerInstance.X = 0f;
                            ContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ContainerInstance.Y = 0f;
                            ContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("TextInstance1.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                            TextInstance1.FontScale = 0.5f;
                            TextInstance1.Height = 29f;
                            TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            TextInstance1.Text = "Final Score:\n";
                            TextInstance1.UseCustomFont = true;
                            TextInstance1.Width = 173f;
                            TextInstance1.X = 0f;
                            TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance1.Y = 0f;
                            TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("FinalScoreValue.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                            FinalScoreValue.FontScale = 0.5f;
                            FinalScoreValue.Height = 27f;
                            FinalScoreValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            FinalScoreValue.UseCustomFont = true;
                            FinalScoreValue.Width = 76f;
                            FinalScoreValue.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FinalScoreValue.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PlayAgainButton.LabelText = "Play Again";
                            PlayAgainButton.X = 0f;
                            PlayAgainButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PlayAgainButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PlayAgainButton.Y = 400f;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setContainerInstanceXFirstValue = false;
                bool setContainerInstanceXSecondValue = false;
                float ContainerInstanceXFirstValue= 0;
                float ContainerInstanceXSecondValue= 0;
                bool setContainerInstanceYFirstValue = false;
                bool setContainerInstanceYSecondValue = false;
                float ContainerInstanceYFirstValue= 0;
                float ContainerInstanceYSecondValue= 0;
                bool setFinalScoreValueFontScaleFirstValue = false;
                bool setFinalScoreValueFontScaleSecondValue = false;
                float FinalScoreValueFontScaleFirstValue= 0;
                float FinalScoreValueFontScaleSecondValue= 0;
                bool setFinalScoreValueHeightFirstValue = false;
                bool setFinalScoreValueHeightSecondValue = false;
                float FinalScoreValueHeightFirstValue= 0;
                float FinalScoreValueHeightSecondValue= 0;
                bool setFinalScoreValueWidthFirstValue = false;
                bool setFinalScoreValueWidthSecondValue = false;
                float FinalScoreValueWidthFirstValue= 0;
                float FinalScoreValueWidthSecondValue= 0;
                bool setPlayAgainButtonXFirstValue = false;
                bool setPlayAgainButtonXSecondValue = false;
                float PlayAgainButtonXFirstValue= 0;
                float PlayAgainButtonXSecondValue= 0;
                bool setPlayAgainButtonYFirstValue = false;
                bool setPlayAgainButtonYSecondValue = false;
                float PlayAgainButtonYFirstValue= 0;
                float PlayAgainButtonYSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                bool setTextInstance1FontScaleFirstValue = false;
                bool setTextInstance1FontScaleSecondValue = false;
                float TextInstance1FontScaleFirstValue= 0;
                float TextInstance1FontScaleSecondValue= 0;
                bool setTextInstance1HeightFirstValue = false;
                bool setTextInstance1HeightSecondValue = false;
                float TextInstance1HeightFirstValue= 0;
                float TextInstance1HeightSecondValue= 0;
                bool setTextInstance1WidthFirstValue = false;
                bool setTextInstance1WidthSecondValue = false;
                float TextInstance1WidthFirstValue= 0;
                float TextInstance1WidthSecondValue= 0;
                bool setTextInstance1XFirstValue = false;
                bool setTextInstance1XSecondValue = false;
                float TextInstance1XFirstValue= 0;
                float TextInstance1XSecondValue= 0;
                bool setTextInstance1YFirstValue = false;
                bool setTextInstance1YSecondValue = false;
                float TextInstance1YFirstValue= 0;
                float TextInstance1YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 46f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 257f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("FinalScoreValue.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                        }
                        setFinalScoreValueFontScaleFirstValue = true;
                        FinalScoreValueFontScaleFirstValue = 0.5f;
                        setFinalScoreValueHeightFirstValue = true;
                        FinalScoreValueHeightFirstValue = 27f;
                        if (interpolationValue < 1)
                        {
                            this.FinalScoreValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.FinalScoreValue.UseCustomFont = true;
                        }
                        setFinalScoreValueWidthFirstValue = true;
                        FinalScoreValueWidthFirstValue = 76f;
                        if (interpolationValue < 1)
                        {
                            this.FinalScoreValue.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FinalScoreValue.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PlayAgainButton.LabelText = "Play Again";
                        }
                        setPlayAgainButtonXFirstValue = true;
                        PlayAgainButtonXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.PlayAgainButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PlayAgainButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPlayAgainButtonYFirstValue = true;
                        PlayAgainButtonYFirstValue = 400f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                        }
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 62f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Game Over";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 331f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance1.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                        }
                        setTextInstance1FontScaleFirstValue = true;
                        TextInstance1FontScaleFirstValue = 0.5f;
                        setTextInstance1HeightFirstValue = true;
                        TextInstance1HeightFirstValue = 29f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "Final Score:\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.UseCustomFont = true;
                        }
                        setTextInstance1WidthFirstValue = true;
                        TextInstance1WidthFirstValue = 173f;
                        setTextInstance1XFirstValue = true;
                        TextInstance1XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstance1YFirstValue = true;
                        TextInstance1YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 46f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 257f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("FinalScoreValue.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                        }
                        setFinalScoreValueFontScaleSecondValue = true;
                        FinalScoreValueFontScaleSecondValue = 0.5f;
                        setFinalScoreValueHeightSecondValue = true;
                        FinalScoreValueHeightSecondValue = 27f;
                        if (interpolationValue >= 1)
                        {
                            this.FinalScoreValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FinalScoreValue.UseCustomFont = true;
                        }
                        setFinalScoreValueWidthSecondValue = true;
                        FinalScoreValueWidthSecondValue = 76f;
                        if (interpolationValue >= 1)
                        {
                            this.FinalScoreValue.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FinalScoreValue.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PlayAgainButton.LabelText = "Play Again";
                        }
                        setPlayAgainButtonXSecondValue = true;
                        PlayAgainButtonXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.PlayAgainButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PlayAgainButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPlayAgainButtonYSecondValue = true;
                        PlayAgainButtonYSecondValue = 400f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                        }
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 62f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Game Over";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 331f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance1.CustomFontFile", "../GlobalContent/BabyCatcher/baby_doll_64.fnt");
                        }
                        setTextInstance1FontScaleSecondValue = true;
                        TextInstance1FontScaleSecondValue = 0.5f;
                        setTextInstance1HeightSecondValue = true;
                        TextInstance1HeightSecondValue = 29f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "Final Score:\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.UseCustomFont = true;
                        }
                        setTextInstance1WidthSecondValue = true;
                        TextInstance1WidthSecondValue = 173f;
                        setTextInstance1XSecondValue = true;
                        TextInstance1XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstance1YSecondValue = true;
                        TextInstance1YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceXFirstValue && setContainerInstanceXSecondValue)
                {
                    ContainerInstance.X = ContainerInstanceXFirstValue * (1 - interpolationValue) + ContainerInstanceXSecondValue * interpolationValue;
                }
                if (setContainerInstanceYFirstValue && setContainerInstanceYSecondValue)
                {
                    ContainerInstance.Y = ContainerInstanceYFirstValue * (1 - interpolationValue) + ContainerInstanceYSecondValue * interpolationValue;
                }
                if (setFinalScoreValueFontScaleFirstValue && setFinalScoreValueFontScaleSecondValue)
                {
                    FinalScoreValue.FontScale = FinalScoreValueFontScaleFirstValue * (1 - interpolationValue) + FinalScoreValueFontScaleSecondValue * interpolationValue;
                }
                if (setFinalScoreValueHeightFirstValue && setFinalScoreValueHeightSecondValue)
                {
                    FinalScoreValue.Height = FinalScoreValueHeightFirstValue * (1 - interpolationValue) + FinalScoreValueHeightSecondValue * interpolationValue;
                }
                if (setFinalScoreValueWidthFirstValue && setFinalScoreValueWidthSecondValue)
                {
                    FinalScoreValue.Width = FinalScoreValueWidthFirstValue * (1 - interpolationValue) + FinalScoreValueWidthSecondValue * interpolationValue;
                }
                if (setPlayAgainButtonXFirstValue && setPlayAgainButtonXSecondValue)
                {
                    PlayAgainButton.X = PlayAgainButtonXFirstValue * (1 - interpolationValue) + PlayAgainButtonXSecondValue * interpolationValue;
                }
                if (setPlayAgainButtonYFirstValue && setPlayAgainButtonYSecondValue)
                {
                    PlayAgainButton.Y = PlayAgainButtonYFirstValue * (1 - interpolationValue) + PlayAgainButtonYSecondValue * interpolationValue;
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstance1FontScaleFirstValue && setTextInstance1FontScaleSecondValue)
                {
                    TextInstance1.FontScale = TextInstance1FontScaleFirstValue * (1 - interpolationValue) + TextInstance1FontScaleSecondValue * interpolationValue;
                }
                if (setTextInstance1HeightFirstValue && setTextInstance1HeightSecondValue)
                {
                    TextInstance1.Height = TextInstance1HeightFirstValue * (1 - interpolationValue) + TextInstance1HeightSecondValue * interpolationValue;
                }
                if (setTextInstance1WidthFirstValue && setTextInstance1WidthSecondValue)
                {
                    TextInstance1.Width = TextInstance1WidthFirstValue * (1 - interpolationValue) + TextInstance1WidthSecondValue * interpolationValue;
                }
                if (setTextInstance1XFirstValue && setTextInstance1XSecondValue)
                {
                    TextInstance1.X = TextInstance1XFirstValue * (1 - interpolationValue) + TextInstance1XSecondValue * interpolationValue;
                }
                if (setTextInstance1YFirstValue && setTextInstance1YSecondValue)
                {
                    TextInstance1.Y = TextInstance1YFirstValue * (1 - interpolationValue) + TextInstance1YSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.GameOverGumRuntime.VariableState fromState,Frbcon2019.GumRuntimes.GameOverGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                PlayAgainButton.StopAnimations();
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ContainerInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ContainerInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.CustomFontFile",
                            Type = "string",
                            Value = TextInstance1.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Font Scale",
                            Type = "float",
                            Value = TextInstance1.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Parent",
                            Type = "string",
                            Value = TextInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance1.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.CustomFontFile",
                            Type = "string",
                            Value = FinalScoreValue.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Font Scale",
                            Type = "float",
                            Value = FinalScoreValue.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Height",
                            Type = "float",
                            Value = FinalScoreValue.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Parent",
                            Type = "string",
                            Value = FinalScoreValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.UseCustomFont",
                            Type = "bool",
                            Value = FinalScoreValue.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Width",
                            Type = "float",
                            Value = FinalScoreValue.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FinalScoreValue.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Y Units",
                            Type = "PositionUnitType",
                            Value = FinalScoreValue.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.LabelText",
                            Type = "string",
                            Value = PlayAgainButton.LabelText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.X",
                            Type = "float",
                            Value = PlayAgainButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PlayAgainButton.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.X Units",
                            Type = "PositionUnitType",
                            Value = PlayAgainButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.Y",
                            Type = "float",
                            Value = PlayAgainButton.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 62f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 331f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 46f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + 257f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ContainerInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ContainerInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.CustomFontFile",
                            Type = "string",
                            Value = TextInstance1.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Font Scale",
                            Type = "float",
                            Value = TextInstance1.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height + 29f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Parent",
                            Type = "string",
                            Value = TextInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance1.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width + 173f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.CustomFontFile",
                            Type = "string",
                            Value = FinalScoreValue.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Font Scale",
                            Type = "float",
                            Value = FinalScoreValue.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Height",
                            Type = "float",
                            Value = FinalScoreValue.Height + 27f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Parent",
                            Type = "string",
                            Value = FinalScoreValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.UseCustomFont",
                            Type = "bool",
                            Value = FinalScoreValue.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Width",
                            Type = "float",
                            Value = FinalScoreValue.Width + 76f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FinalScoreValue.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FinalScoreValue.Y Units",
                            Type = "PositionUnitType",
                            Value = FinalScoreValue.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.LabelText",
                            Type = "string",
                            Value = PlayAgainButton.LabelText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.X",
                            Type = "float",
                            Value = PlayAgainButton.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PlayAgainButton.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.X Units",
                            Type = "PositionUnitType",
                            Value = PlayAgainButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayAgainButton.Y",
                            Type = "float",
                            Value = PlayAgainButton.Y + 400f
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                }
                base.ApplyState(state);
            }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime FinalScoreValue { get; set; }
            public Frbcon2019.GumRuntimes.ButtonRuntime PlayAgainButton { get; set; }
            public GameOverGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameOverGum");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState () 
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers) 
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences () 
            {
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as Frbcon2019.GumRuntimes.TextRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as Frbcon2019.GumRuntimes.ContainerRuntime;
                TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as Frbcon2019.GumRuntimes.TextRuntime;
                FinalScoreValue = this.GetGraphicalUiElementByName("FinalScoreValue") as Frbcon2019.GumRuntimes.TextRuntime;
                PlayAgainButton = this.GetGraphicalUiElementByName("PlayAgainButton") as Frbcon2019.GumRuntimes.ButtonRuntime;
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer) 
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize () 
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
        }
    }
