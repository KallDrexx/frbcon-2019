    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class ButtonRuntime : Frbcon2019.GumRuntimes.SpriteRuntime
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
                            Alpha = 255;
                            Animate = false;
                            Blue = 255;
                            FlipHorizontal = false;
                            FlipVertical = false;
                            Green = 248;
                            Height = 68f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Red = 240;
                            Rotation = 0f;
                            SetProperty("SourceFile", "blueSheet.png");
                            TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TextureHeight = 45;
                            TextureHeightScale = 1f;
                            TextureLeft = 0;
                            TextureTop = 0;
                            TextureWidth = 190;
                            TextureWidthScale = 1f;
                            Visible = true;
                            Width = 272f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Wrap = false;
                            X = 0f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Y = 0f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Label.Blue = 0;
                            Label.Green = 0;
                            Label.Height = 0f;
                            Label.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Label.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Label.Red = 0;
                            Label.Text = "";
                            Label.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Label.Width = 0f;
                            Label.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Label.X = 0f;
                            Label.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Label.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Label.Y = 0f;
                            Label.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Label.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setAlphaFirstValue = false;
                bool setAlphaSecondValue = false;
                int AlphaFirstValue= 0;
                int AlphaSecondValue= 0;
                bool setBlueFirstValue = false;
                bool setBlueSecondValue = false;
                int BlueFirstValue= 0;
                int BlueSecondValue= 0;
                bool setGreenFirstValue = false;
                bool setGreenSecondValue = false;
                int GreenFirstValue= 0;
                int GreenSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLabelBlueFirstValue = false;
                bool setLabelBlueSecondValue = false;
                int LabelBlueFirstValue= 0;
                int LabelBlueSecondValue= 0;
                bool setLabelGreenFirstValue = false;
                bool setLabelGreenSecondValue = false;
                int LabelGreenFirstValue= 0;
                int LabelGreenSecondValue= 0;
                bool setLabelHeightFirstValue = false;
                bool setLabelHeightSecondValue = false;
                float LabelHeightFirstValue= 0;
                float LabelHeightSecondValue= 0;
                bool setLabelRedFirstValue = false;
                bool setLabelRedSecondValue = false;
                int LabelRedFirstValue= 0;
                int LabelRedSecondValue= 0;
                bool setLabelWidthFirstValue = false;
                bool setLabelWidthSecondValue = false;
                float LabelWidthFirstValue= 0;
                float LabelWidthSecondValue= 0;
                bool setLabelXFirstValue = false;
                bool setLabelXSecondValue = false;
                float LabelXFirstValue= 0;
                float LabelXSecondValue= 0;
                bool setLabelYFirstValue = false;
                bool setLabelYSecondValue = false;
                float LabelYFirstValue= 0;
                float LabelYSecondValue= 0;
                bool setRedFirstValue = false;
                bool setRedSecondValue = false;
                int RedFirstValue= 0;
                int RedSecondValue= 0;
                bool setRotationFirstValue = false;
                bool setRotationSecondValue = false;
                float RotationFirstValue= 0;
                float RotationSecondValue= 0;
                bool setTextureHeightFirstValue = false;
                bool setTextureHeightSecondValue = false;
                int TextureHeightFirstValue= 0;
                int TextureHeightSecondValue= 0;
                bool setTextureHeightScaleFirstValue = false;
                bool setTextureHeightScaleSecondValue = false;
                float TextureHeightScaleFirstValue= 0;
                float TextureHeightScaleSecondValue= 0;
                bool setTextureLeftFirstValue = false;
                bool setTextureLeftSecondValue = false;
                int TextureLeftFirstValue= 0;
                int TextureLeftSecondValue= 0;
                bool setTextureTopFirstValue = false;
                bool setTextureTopSecondValue = false;
                int TextureTopFirstValue= 0;
                int TextureTopSecondValue= 0;
                bool setTextureWidthFirstValue = false;
                bool setTextureWidthSecondValue = false;
                int TextureWidthFirstValue= 0;
                int TextureWidthSecondValue= 0;
                bool setTextureWidthScaleFirstValue = false;
                bool setTextureWidthScaleSecondValue = false;
                float TextureWidthScaleFirstValue= 0;
                float TextureWidthScaleSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setAlphaFirstValue = true;
                        AlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.Animate = false;
                        }
                        setBlueFirstValue = true;
                        BlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.FlipHorizontal = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FlipVertical = false;
                        }
                        setGreenFirstValue = true;
                        GreenFirstValue = 248;
                        setHeightFirstValue = true;
                        HeightFirstValue = 68f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLabelBlueFirstValue = true;
                        LabelBlueFirstValue = 0;
                        setLabelGreenFirstValue = true;
                        LabelGreenFirstValue = 0;
                        setLabelHeightFirstValue = true;
                        LabelHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Label.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Label.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setLabelRedFirstValue = true;
                        LabelRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.Label.Text = "";
                        }
                        if (interpolationValue < 1)
                        {
                            this.Label.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setLabelWidthFirstValue = true;
                        LabelWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Label.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setLabelXFirstValue = true;
                        LabelXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Label.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Label.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLabelYFirstValue = true;
                        LabelYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Label.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Label.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRedFirstValue = true;
                        RedFirstValue = 240;
                        setRotationFirstValue = true;
                        RotationFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SourceFile", "blueSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTextureHeightFirstValue = true;
                        TextureHeightFirstValue = 45;
                        setTextureHeightScaleFirstValue = true;
                        TextureHeightScaleFirstValue = 1f;
                        setTextureLeftFirstValue = true;
                        TextureLeftFirstValue = 0;
                        setTextureTopFirstValue = true;
                        TextureTopFirstValue = 0;
                        setTextureWidthFirstValue = true;
                        TextureWidthFirstValue = 190;
                        setTextureWidthScaleFirstValue = true;
                        TextureWidthScaleFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 272f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Wrap = false;
                        }
                        setXFirstValue = true;
                        XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setYFirstValue = true;
                        YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setAlphaSecondValue = true;
                        AlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.Animate = false;
                        }
                        setBlueSecondValue = true;
                        BlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.FlipHorizontal = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FlipVertical = false;
                        }
                        setGreenSecondValue = true;
                        GreenSecondValue = 248;
                        setHeightSecondValue = true;
                        HeightSecondValue = 68f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLabelBlueSecondValue = true;
                        LabelBlueSecondValue = 0;
                        setLabelGreenSecondValue = true;
                        LabelGreenSecondValue = 0;
                        setLabelHeightSecondValue = true;
                        LabelHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Label.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Label.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setLabelRedSecondValue = true;
                        LabelRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.Label.Text = "";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Label.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setLabelWidthSecondValue = true;
                        LabelWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Label.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setLabelXSecondValue = true;
                        LabelXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Label.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Label.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLabelYSecondValue = true;
                        LabelYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Label.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Label.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRedSecondValue = true;
                        RedSecondValue = 240;
                        setRotationSecondValue = true;
                        RotationSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SourceFile", "blueSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTextureHeightSecondValue = true;
                        TextureHeightSecondValue = 45;
                        setTextureHeightScaleSecondValue = true;
                        TextureHeightScaleSecondValue = 1f;
                        setTextureLeftSecondValue = true;
                        TextureLeftSecondValue = 0;
                        setTextureTopSecondValue = true;
                        TextureTopSecondValue = 0;
                        setTextureWidthSecondValue = true;
                        TextureWidthSecondValue = 190;
                        setTextureWidthScaleSecondValue = true;
                        TextureWidthScaleSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 272f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Wrap = false;
                        }
                        setXSecondValue = true;
                        XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setYSecondValue = true;
                        YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setAlphaFirstValue && setAlphaSecondValue)
                {
                    Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(AlphaFirstValue* (1 - interpolationValue) + AlphaSecondValue * interpolationValue);
                }
                if (setBlueFirstValue && setBlueSecondValue)
                {
                    Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BlueFirstValue* (1 - interpolationValue) + BlueSecondValue * interpolationValue);
                }
                if (setGreenFirstValue && setGreenSecondValue)
                {
                    Green = FlatRedBall.Math.MathFunctions.RoundToInt(GreenFirstValue* (1 - interpolationValue) + GreenSecondValue * interpolationValue);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLabelBlueFirstValue && setLabelBlueSecondValue)
                {
                    Label.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(LabelBlueFirstValue* (1 - interpolationValue) + LabelBlueSecondValue * interpolationValue);
                }
                if (setLabelGreenFirstValue && setLabelGreenSecondValue)
                {
                    Label.Green = FlatRedBall.Math.MathFunctions.RoundToInt(LabelGreenFirstValue* (1 - interpolationValue) + LabelGreenSecondValue * interpolationValue);
                }
                if (setLabelHeightFirstValue && setLabelHeightSecondValue)
                {
                    Label.Height = LabelHeightFirstValue * (1 - interpolationValue) + LabelHeightSecondValue * interpolationValue;
                }
                if (setLabelRedFirstValue && setLabelRedSecondValue)
                {
                    Label.Red = FlatRedBall.Math.MathFunctions.RoundToInt(LabelRedFirstValue* (1 - interpolationValue) + LabelRedSecondValue * interpolationValue);
                }
                if (setLabelWidthFirstValue && setLabelWidthSecondValue)
                {
                    Label.Width = LabelWidthFirstValue * (1 - interpolationValue) + LabelWidthSecondValue * interpolationValue;
                }
                if (setLabelXFirstValue && setLabelXSecondValue)
                {
                    Label.X = LabelXFirstValue * (1 - interpolationValue) + LabelXSecondValue * interpolationValue;
                }
                if (setLabelYFirstValue && setLabelYSecondValue)
                {
                    Label.Y = LabelYFirstValue * (1 - interpolationValue) + LabelYSecondValue * interpolationValue;
                }
                if (setRedFirstValue && setRedSecondValue)
                {
                    Red = FlatRedBall.Math.MathFunctions.RoundToInt(RedFirstValue* (1 - interpolationValue) + RedSecondValue * interpolationValue);
                }
                if (setRotationFirstValue && setRotationSecondValue)
                {
                    Rotation = RotationFirstValue * (1 - interpolationValue) + RotationSecondValue * interpolationValue;
                }
                if (setTextureHeightFirstValue && setTextureHeightSecondValue)
                {
                    TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TextureHeightFirstValue* (1 - interpolationValue) + TextureHeightSecondValue * interpolationValue);
                }
                if (setTextureHeightScaleFirstValue && setTextureHeightScaleSecondValue)
                {
                    TextureHeightScale = TextureHeightScaleFirstValue * (1 - interpolationValue) + TextureHeightScaleSecondValue * interpolationValue;
                }
                if (setTextureLeftFirstValue && setTextureLeftSecondValue)
                {
                    TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TextureLeftFirstValue* (1 - interpolationValue) + TextureLeftSecondValue * interpolationValue);
                }
                if (setTextureTopFirstValue && setTextureTopSecondValue)
                {
                    TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TextureTopFirstValue* (1 - interpolationValue) + TextureTopSecondValue * interpolationValue);
                }
                if (setTextureWidthFirstValue && setTextureWidthSecondValue)
                {
                    TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TextureWidthFirstValue* (1 - interpolationValue) + TextureWidthSecondValue * interpolationValue);
                }
                if (setTextureWidthScaleFirstValue && setTextureWidthScaleSecondValue)
                {
                    TextureWidthScale = TextureWidthScaleFirstValue * (1 - interpolationValue) + TextureWidthScaleSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.ButtonRuntime.VariableState fromState,Frbcon2019.GumRuntimes.ButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "Alpha",
                            Type = "int",
                            Value = Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Animate",
                            Type = "bool",
                            Value = Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Blue",
                            Type = "int",
                            Value = Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FlipHorizontal",
                            Type = "bool",
                            Value = FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FlipVertical",
                            Type = "bool",
                            Value = FlipVertical
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Green",
                            Type = "int",
                            Value = Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Red",
                            Type = "int",
                            Value = Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Rotation",
                            Type = "float",
                            Value = Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SourceFile",
                            Type = "string",
                            Value = SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Address",
                            Type = "TextureAddress",
                            Value = TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Height",
                            Type = "int",
                            Value = TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Height Scale",
                            Type = "float",
                            Value = TextureHeightScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Left",
                            Type = "int",
                            Value = TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Top",
                            Type = "int",
                            Value = TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Width",
                            Type = "int",
                            Value = TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Width Scale",
                            Type = "float",
                            Value = TextureWidthScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Wrap",
                            Type = "bool",
                            Value = Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Blue",
                            Type = "int",
                            Value = Label.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Green",
                            Type = "int",
                            Value = Label.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Height",
                            Type = "float",
                            Value = Label.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Height Units",
                            Type = "DimensionUnitType",
                            Value = Label.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Label.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Red",
                            Type = "int",
                            Value = Label.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Text",
                            Type = "string",
                            Value = Label.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = Label.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Width",
                            Type = "float",
                            Value = Label.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Width Units",
                            Type = "DimensionUnitType",
                            Value = Label.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.X",
                            Type = "float",
                            Value = Label.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Label.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.X Units",
                            Type = "PositionUnitType",
                            Value = Label.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Y",
                            Type = "float",
                            Value = Label.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Label.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Y Units",
                            Type = "PositionUnitType",
                            Value = Label.YUnits
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
                            Name = "Alpha",
                            Type = "int",
                            Value = Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Animate",
                            Type = "bool",
                            Value = Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Blue",
                            Type = "int",
                            Value = Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FlipHorizontal",
                            Type = "bool",
                            Value = FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FlipVertical",
                            Type = "bool",
                            Value = FlipVertical
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Green",
                            Type = "int",
                            Value = Green + 248
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 68f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Red",
                            Type = "int",
                            Value = Red + 240
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Rotation",
                            Type = "float",
                            Value = Rotation + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SourceFile",
                            Type = "string",
                            Value = SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Address",
                            Type = "TextureAddress",
                            Value = TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Height",
                            Type = "int",
                            Value = TextureHeight + 45
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Height Scale",
                            Type = "float",
                            Value = TextureHeightScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Left",
                            Type = "int",
                            Value = TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Top",
                            Type = "int",
                            Value = TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Width",
                            Type = "int",
                            Value = TextureWidth + 190
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Texture Width Scale",
                            Type = "float",
                            Value = TextureWidthScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 272f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Wrap",
                            Type = "bool",
                            Value = Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Blue",
                            Type = "int",
                            Value = Label.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Green",
                            Type = "int",
                            Value = Label.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Height",
                            Type = "float",
                            Value = Label.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Height Units",
                            Type = "DimensionUnitType",
                            Value = Label.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Label.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Red",
                            Type = "int",
                            Value = Label.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Text",
                            Type = "string",
                            Value = Label.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = Label.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Width",
                            Type = "float",
                            Value = Label.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Width Units",
                            Type = "DimensionUnitType",
                            Value = Label.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.X",
                            Type = "float",
                            Value = Label.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Label.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.X Units",
                            Type = "PositionUnitType",
                            Value = Label.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Y",
                            Type = "float",
                            Value = Label.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Label.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Label.Y Units",
                            Type = "PositionUnitType",
                            Value = Label.YUnits
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
            private Frbcon2019.GumRuntimes.TextRuntime Label { get; set; }
            public string LabelText
            {
                get
                {
                    return Label.Text;
                }
                set
                {
                    if (Label.Text != value)
                    {
                        Label.Text = value;
                        LabelTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler LabelTextChanged;
            public ButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Button");
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
                Label = this.GetGraphicalUiElementByName("Label") as Frbcon2019.GumRuntimes.TextRuntime;
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
