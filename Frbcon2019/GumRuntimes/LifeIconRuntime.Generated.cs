    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class LifeIconRuntime : Frbcon2019.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default,
                Lost
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
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Heart.Animate = false;
                            Heart.Blue = 0;
                            Heart.Green = 255;
                            Heart.Height = 100f;
                            Heart.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Heart.Red = 0;
                            SetProperty("Heart.SourceFile", "../GlobalContent/BabyCatcher/babe_ease_spritesheet.png");
                            Heart.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Heart.TextureHeight = 115;
                            Heart.TextureLeft = 521;
                            Heart.TextureTop = 586;
                            Heart.TextureWidth = 115;
                            Heart.Visible = true;
                            Heart.Width = 100f;
                            Heart.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Heart.X = 0f;
                            Heart.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Heart.Y = 0f;
                            Heart.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            LostIndicator.Height = 100f;
                            LostIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("LostIndicator.SourceFile", "../GlobalContent/cancel.png");
                            LostIndicator.Visible = false;
                            LostIndicator.Width = 100f;
                            LostIndicator.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                        case  VariableState.Lost:
                            Heart.Blue = 0;
                            Heart.Green = 0;
                            Heart.Red = 139;
                            LostIndicator.Blue = 0;
                            LostIndicator.Green = 0;
                            LostIndicator.Red = 255;
                            SetProperty("LostIndicator.SourceFile", "cancel.png");
                            LostIndicator.Visible = true;
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
                bool setHeartBlueFirstValue = false;
                bool setHeartBlueSecondValue = false;
                int HeartBlueFirstValue= 0;
                int HeartBlueSecondValue= 0;
                bool setHeartGreenFirstValue = false;
                bool setHeartGreenSecondValue = false;
                int HeartGreenFirstValue= 0;
                int HeartGreenSecondValue= 0;
                bool setHeartHeightFirstValue = false;
                bool setHeartHeightSecondValue = false;
                float HeartHeightFirstValue= 0;
                float HeartHeightSecondValue= 0;
                bool setHeartRedFirstValue = false;
                bool setHeartRedSecondValue = false;
                int HeartRedFirstValue= 0;
                int HeartRedSecondValue= 0;
                bool setHeartTextureHeightFirstValue = false;
                bool setHeartTextureHeightSecondValue = false;
                int HeartTextureHeightFirstValue= 0;
                int HeartTextureHeightSecondValue= 0;
                bool setHeartTextureLeftFirstValue = false;
                bool setHeartTextureLeftSecondValue = false;
                int HeartTextureLeftFirstValue= 0;
                int HeartTextureLeftSecondValue= 0;
                bool setHeartTextureTopFirstValue = false;
                bool setHeartTextureTopSecondValue = false;
                int HeartTextureTopFirstValue= 0;
                int HeartTextureTopSecondValue= 0;
                bool setHeartTextureWidthFirstValue = false;
                bool setHeartTextureWidthSecondValue = false;
                int HeartTextureWidthFirstValue= 0;
                int HeartTextureWidthSecondValue= 0;
                bool setHeartWidthFirstValue = false;
                bool setHeartWidthSecondValue = false;
                float HeartWidthFirstValue= 0;
                float HeartWidthSecondValue= 0;
                bool setHeartXFirstValue = false;
                bool setHeartXSecondValue = false;
                float HeartXFirstValue= 0;
                float HeartXSecondValue= 0;
                bool setHeartYFirstValue = false;
                bool setHeartYSecondValue = false;
                float HeartYFirstValue= 0;
                float HeartYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLostIndicatorHeightFirstValue = false;
                bool setLostIndicatorHeightSecondValue = false;
                float LostIndicatorHeightFirstValue= 0;
                float LostIndicatorHeightSecondValue= 0;
                bool setLostIndicatorWidthFirstValue = false;
                bool setLostIndicatorWidthSecondValue = false;
                float LostIndicatorWidthFirstValue= 0;
                float LostIndicatorWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setLostIndicatorBlueFirstValue = false;
                bool setLostIndicatorBlueSecondValue = false;
                int LostIndicatorBlueFirstValue= 0;
                int LostIndicatorBlueSecondValue= 0;
                bool setLostIndicatorGreenFirstValue = false;
                bool setLostIndicatorGreenSecondValue = false;
                int LostIndicatorGreenFirstValue= 0;
                int LostIndicatorGreenSecondValue= 0;
                bool setLostIndicatorRedFirstValue = false;
                bool setLostIndicatorRedSecondValue = false;
                int LostIndicatorRedFirstValue= 0;
                int LostIndicatorRedSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.Heart.Animate = false;
                        }
                        setHeartBlueFirstValue = true;
                        HeartBlueFirstValue = 0;
                        setHeartGreenFirstValue = true;
                        HeartGreenFirstValue = 255;
                        setHeartHeightFirstValue = true;
                        HeartHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Heart.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeartRedFirstValue = true;
                        HeartRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Heart.SourceFile", "../GlobalContent/BabyCatcher/babe_ease_spritesheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Heart.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHeartTextureHeightFirstValue = true;
                        HeartTextureHeightFirstValue = 115;
                        setHeartTextureLeftFirstValue = true;
                        HeartTextureLeftFirstValue = 521;
                        setHeartTextureTopFirstValue = true;
                        HeartTextureTopFirstValue = 586;
                        setHeartTextureWidthFirstValue = true;
                        HeartTextureWidthFirstValue = 115;
                        if (interpolationValue < 1)
                        {
                            this.Heart.Visible = true;
                        }
                        setHeartWidthFirstValue = true;
                        HeartWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Heart.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeartXFirstValue = true;
                        HeartXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Heart.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setHeartYFirstValue = true;
                        HeartYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Heart.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLostIndicatorHeightFirstValue = true;
                        LostIndicatorHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LostIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("LostIndicator.SourceFile", "../GlobalContent/cancel.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LostIndicator.Visible = false;
                        }
                        setLostIndicatorWidthFirstValue = true;
                        LostIndicatorWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LostIndicator.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                    case  VariableState.Lost:
                        setHeartBlueFirstValue = true;
                        HeartBlueFirstValue = 0;
                        setHeartGreenFirstValue = true;
                        HeartGreenFirstValue = 0;
                        setHeartRedFirstValue = true;
                        HeartRedFirstValue = 139;
                        setLostIndicatorBlueFirstValue = true;
                        LostIndicatorBlueFirstValue = 0;
                        setLostIndicatorGreenFirstValue = true;
                        LostIndicatorGreenFirstValue = 0;
                        setLostIndicatorRedFirstValue = true;
                        LostIndicatorRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("LostIndicator.SourceFile", "cancel.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LostIndicator.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.Heart.Animate = false;
                        }
                        setHeartBlueSecondValue = true;
                        HeartBlueSecondValue = 0;
                        setHeartGreenSecondValue = true;
                        HeartGreenSecondValue = 255;
                        setHeartHeightSecondValue = true;
                        HeartHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Heart.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeartRedSecondValue = true;
                        HeartRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Heart.SourceFile", "../GlobalContent/BabyCatcher/babe_ease_spritesheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Heart.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setHeartTextureHeightSecondValue = true;
                        HeartTextureHeightSecondValue = 115;
                        setHeartTextureLeftSecondValue = true;
                        HeartTextureLeftSecondValue = 521;
                        setHeartTextureTopSecondValue = true;
                        HeartTextureTopSecondValue = 586;
                        setHeartTextureWidthSecondValue = true;
                        HeartTextureWidthSecondValue = 115;
                        if (interpolationValue >= 1)
                        {
                            this.Heart.Visible = true;
                        }
                        setHeartWidthSecondValue = true;
                        HeartWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Heart.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeartXSecondValue = true;
                        HeartXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Heart.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setHeartYSecondValue = true;
                        HeartYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Heart.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLostIndicatorHeightSecondValue = true;
                        LostIndicatorHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LostIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LostIndicator.SourceFile", "../GlobalContent/cancel.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LostIndicator.Visible = false;
                        }
                        setLostIndicatorWidthSecondValue = true;
                        LostIndicatorWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LostIndicator.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                    case  VariableState.Lost:
                        setHeartBlueSecondValue = true;
                        HeartBlueSecondValue = 0;
                        setHeartGreenSecondValue = true;
                        HeartGreenSecondValue = 0;
                        setHeartRedSecondValue = true;
                        HeartRedSecondValue = 139;
                        setLostIndicatorBlueSecondValue = true;
                        LostIndicatorBlueSecondValue = 0;
                        setLostIndicatorGreenSecondValue = true;
                        LostIndicatorGreenSecondValue = 0;
                        setLostIndicatorRedSecondValue = true;
                        LostIndicatorRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LostIndicator.SourceFile", "cancel.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LostIndicator.Visible = true;
                        }
                        break;
                }
                if (setHeartBlueFirstValue && setHeartBlueSecondValue)
                {
                    Heart.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(HeartBlueFirstValue* (1 - interpolationValue) + HeartBlueSecondValue * interpolationValue);
                }
                if (setHeartGreenFirstValue && setHeartGreenSecondValue)
                {
                    Heart.Green = FlatRedBall.Math.MathFunctions.RoundToInt(HeartGreenFirstValue* (1 - interpolationValue) + HeartGreenSecondValue * interpolationValue);
                }
                if (setHeartHeightFirstValue && setHeartHeightSecondValue)
                {
                    Heart.Height = HeartHeightFirstValue * (1 - interpolationValue) + HeartHeightSecondValue * interpolationValue;
                }
                if (setHeartRedFirstValue && setHeartRedSecondValue)
                {
                    Heart.Red = FlatRedBall.Math.MathFunctions.RoundToInt(HeartRedFirstValue* (1 - interpolationValue) + HeartRedSecondValue * interpolationValue);
                }
                if (setHeartTextureHeightFirstValue && setHeartTextureHeightSecondValue)
                {
                    Heart.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(HeartTextureHeightFirstValue* (1 - interpolationValue) + HeartTextureHeightSecondValue * interpolationValue);
                }
                if (setHeartTextureLeftFirstValue && setHeartTextureLeftSecondValue)
                {
                    Heart.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(HeartTextureLeftFirstValue* (1 - interpolationValue) + HeartTextureLeftSecondValue * interpolationValue);
                }
                if (setHeartTextureTopFirstValue && setHeartTextureTopSecondValue)
                {
                    Heart.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(HeartTextureTopFirstValue* (1 - interpolationValue) + HeartTextureTopSecondValue * interpolationValue);
                }
                if (setHeartTextureWidthFirstValue && setHeartTextureWidthSecondValue)
                {
                    Heart.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(HeartTextureWidthFirstValue* (1 - interpolationValue) + HeartTextureWidthSecondValue * interpolationValue);
                }
                if (setHeartWidthFirstValue && setHeartWidthSecondValue)
                {
                    Heart.Width = HeartWidthFirstValue * (1 - interpolationValue) + HeartWidthSecondValue * interpolationValue;
                }
                if (setHeartXFirstValue && setHeartXSecondValue)
                {
                    Heart.X = HeartXFirstValue * (1 - interpolationValue) + HeartXSecondValue * interpolationValue;
                }
                if (setHeartYFirstValue && setHeartYSecondValue)
                {
                    Heart.Y = HeartYFirstValue * (1 - interpolationValue) + HeartYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLostIndicatorHeightFirstValue && setLostIndicatorHeightSecondValue)
                {
                    LostIndicator.Height = LostIndicatorHeightFirstValue * (1 - interpolationValue) + LostIndicatorHeightSecondValue * interpolationValue;
                }
                if (setLostIndicatorWidthFirstValue && setLostIndicatorWidthSecondValue)
                {
                    LostIndicator.Width = LostIndicatorWidthFirstValue * (1 - interpolationValue) + LostIndicatorWidthSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setLostIndicatorBlueFirstValue && setLostIndicatorBlueSecondValue)
                {
                    LostIndicator.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(LostIndicatorBlueFirstValue* (1 - interpolationValue) + LostIndicatorBlueSecondValue * interpolationValue);
                }
                if (setLostIndicatorGreenFirstValue && setLostIndicatorGreenSecondValue)
                {
                    LostIndicator.Green = FlatRedBall.Math.MathFunctions.RoundToInt(LostIndicatorGreenFirstValue* (1 - interpolationValue) + LostIndicatorGreenSecondValue * interpolationValue);
                }
                if (setLostIndicatorRedFirstValue && setLostIndicatorRedSecondValue)
                {
                    LostIndicator.Red = FlatRedBall.Math.MathFunctions.RoundToInt(LostIndicatorRedFirstValue* (1 - interpolationValue) + LostIndicatorRedSecondValue * interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.LifeIconRuntime.VariableState fromState,Frbcon2019.GumRuntimes.LifeIconRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Animate",
                            Type = "bool",
                            Value = Heart.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Blue",
                            Type = "int",
                            Value = Heart.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Green",
                            Type = "int",
                            Value = Heart.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Height",
                            Type = "float",
                            Value = Heart.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Height Units",
                            Type = "DimensionUnitType",
                            Value = Heart.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Red",
                            Type = "int",
                            Value = Heart.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.SourceFile",
                            Type = "string",
                            Value = Heart.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Address",
                            Type = "TextureAddress",
                            Value = Heart.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Height",
                            Type = "int",
                            Value = Heart.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Left",
                            Type = "int",
                            Value = Heart.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Top",
                            Type = "int",
                            Value = Heart.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Width",
                            Type = "int",
                            Value = Heart.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Visible",
                            Type = "bool",
                            Value = Heart.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Width",
                            Type = "float",
                            Value = Heart.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Width Units",
                            Type = "DimensionUnitType",
                            Value = Heart.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.X",
                            Type = "float",
                            Value = Heart.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.X Units",
                            Type = "PositionUnitType",
                            Value = Heart.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Y",
                            Type = "float",
                            Value = Heart.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Y Units",
                            Type = "PositionUnitType",
                            Value = Heart.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Height",
                            Type = "float",
                            Value = LostIndicator.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Height Units",
                            Type = "DimensionUnitType",
                            Value = LostIndicator.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.SourceFile",
                            Type = "string",
                            Value = LostIndicator.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Visible",
                            Type = "bool",
                            Value = LostIndicator.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Width",
                            Type = "float",
                            Value = LostIndicator.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Width Units",
                            Type = "DimensionUnitType",
                            Value = LostIndicator.WidthUnits
                        }
                        );
                        break;
                    case  VariableState.Lost:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Blue",
                            Type = "int",
                            Value = Heart.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Green",
                            Type = "int",
                            Value = Heart.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Red",
                            Type = "int",
                            Value = Heart.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Blue",
                            Type = "int",
                            Value = LostIndicator.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Green",
                            Type = "int",
                            Value = LostIndicator.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Red",
                            Type = "int",
                            Value = LostIndicator.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.SourceFile",
                            Type = "string",
                            Value = LostIndicator.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Visible",
                            Type = "bool",
                            Value = LostIndicator.Visible
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 100f
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
                            Name = "Width",
                            Type = "float",
                            Value = Width + 100f
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
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Animate",
                            Type = "bool",
                            Value = Heart.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Blue",
                            Type = "int",
                            Value = Heart.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Green",
                            Type = "int",
                            Value = Heart.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Height",
                            Type = "float",
                            Value = Heart.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Height Units",
                            Type = "DimensionUnitType",
                            Value = Heart.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Red",
                            Type = "int",
                            Value = Heart.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.SourceFile",
                            Type = "string",
                            Value = Heart.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Address",
                            Type = "TextureAddress",
                            Value = Heart.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Height",
                            Type = "int",
                            Value = Heart.TextureHeight + 115
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Left",
                            Type = "int",
                            Value = Heart.TextureLeft + 521
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Top",
                            Type = "int",
                            Value = Heart.TextureTop + 586
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Texture Width",
                            Type = "int",
                            Value = Heart.TextureWidth + 115
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Visible",
                            Type = "bool",
                            Value = Heart.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Width",
                            Type = "float",
                            Value = Heart.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Width Units",
                            Type = "DimensionUnitType",
                            Value = Heart.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.X",
                            Type = "float",
                            Value = Heart.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.X Units",
                            Type = "PositionUnitType",
                            Value = Heart.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Y",
                            Type = "float",
                            Value = Heart.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Y Units",
                            Type = "PositionUnitType",
                            Value = Heart.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Height",
                            Type = "float",
                            Value = LostIndicator.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Height Units",
                            Type = "DimensionUnitType",
                            Value = LostIndicator.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.SourceFile",
                            Type = "string",
                            Value = LostIndicator.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Visible",
                            Type = "bool",
                            Value = LostIndicator.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Width",
                            Type = "float",
                            Value = LostIndicator.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Width Units",
                            Type = "DimensionUnitType",
                            Value = LostIndicator.WidthUnits
                        }
                        );
                        break;
                    case  VariableState.Lost:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Blue",
                            Type = "int",
                            Value = Heart.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Green",
                            Type = "int",
                            Value = Heart.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Heart.Red",
                            Type = "int",
                            Value = Heart.Red + 139
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Blue",
                            Type = "int",
                            Value = LostIndicator.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Green",
                            Type = "int",
                            Value = LostIndicator.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Red",
                            Type = "int",
                            Value = LostIndicator.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.SourceFile",
                            Type = "string",
                            Value = LostIndicator.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LostIndicator.Visible",
                            Type = "bool",
                            Value = LostIndicator.Visible
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
                        if (state.Name == "Lost") this.mCurrentVariableState = VariableState.Lost;
                    }
                }
                base.ApplyState(state);
            }
            private Frbcon2019.GumRuntimes.SpriteRuntime Heart { get; set; }
            private Frbcon2019.GumRuntimes.SpriteRuntime LostIndicator { get; set; }
            public LifeIconRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LifeIcon");
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
                Heart = this.GetGraphicalUiElementByName("Heart") as Frbcon2019.GumRuntimes.SpriteRuntime;
                LostIndicator = this.GetGraphicalUiElementByName("LostIndicator") as Frbcon2019.GumRuntimes.SpriteRuntime;
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
