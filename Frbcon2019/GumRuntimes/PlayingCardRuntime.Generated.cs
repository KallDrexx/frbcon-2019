    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class PlayingCardRuntime : Frbcon2019.GumRuntimes.ContainerRuntime
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
                            Width = 100f;
                            CardBack.Animate = false;
                            CardBack.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("CardBack.SourceFile", "cardback.png");
                            CardBack.TextureHeight = 1755;
                            CardBack.TextureLeft = 0;
                            CardBack.TextureWidth = 4096;
                            CardBack.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CardFront.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("CardFront.SourceFile", "modern_13x4x560x780.png");
                            CardFront.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            CardFront.TextureHeight = 139;
                            CardFront.TextureLeft = 0;
                            CardFront.TextureTop = 0;
                            CardFront.TextureWidth = 100;
                            CardFront.Visible = false;
                            CardFront.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                bool setCardBackTextureHeightFirstValue = false;
                bool setCardBackTextureHeightSecondValue = false;
                int CardBackTextureHeightFirstValue= 0;
                int CardBackTextureHeightSecondValue= 0;
                bool setCardBackTextureLeftFirstValue = false;
                bool setCardBackTextureLeftSecondValue = false;
                int CardBackTextureLeftFirstValue= 0;
                int CardBackTextureLeftSecondValue= 0;
                bool setCardBackTextureWidthFirstValue = false;
                bool setCardBackTextureWidthSecondValue = false;
                int CardBackTextureWidthFirstValue= 0;
                int CardBackTextureWidthSecondValue= 0;
                bool setCardFrontTextureHeightFirstValue = false;
                bool setCardFrontTextureHeightSecondValue = false;
                int CardFrontTextureHeightFirstValue= 0;
                int CardFrontTextureHeightSecondValue= 0;
                bool setCardFrontTextureLeftFirstValue = false;
                bool setCardFrontTextureLeftSecondValue = false;
                int CardFrontTextureLeftFirstValue= 0;
                int CardFrontTextureLeftSecondValue= 0;
                bool setCardFrontTextureTopFirstValue = false;
                bool setCardFrontTextureTopSecondValue = false;
                int CardFrontTextureTopFirstValue= 0;
                int CardFrontTextureTopSecondValue= 0;
                bool setCardFrontTextureWidthFirstValue = false;
                bool setCardFrontTextureWidthSecondValue = false;
                int CardFrontTextureWidthFirstValue= 0;
                int CardFrontTextureWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.CardBack.Animate = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CardBack.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CardBack.SourceFile", "cardback.png");
                        }
                        setCardBackTextureHeightFirstValue = true;
                        CardBackTextureHeightFirstValue = 1755;
                        setCardBackTextureLeftFirstValue = true;
                        CardBackTextureLeftFirstValue = 0;
                        setCardBackTextureWidthFirstValue = true;
                        CardBackTextureWidthFirstValue = 4096;
                        if (interpolationValue < 1)
                        {
                            this.CardBack.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CardFront.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CardFront.SourceFile", "modern_13x4x560x780.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CardFront.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setCardFrontTextureHeightFirstValue = true;
                        CardFrontTextureHeightFirstValue = 139;
                        setCardFrontTextureLeftFirstValue = true;
                        CardFrontTextureLeftFirstValue = 0;
                        setCardFrontTextureTopFirstValue = true;
                        CardFrontTextureTopFirstValue = 0;
                        setCardFrontTextureWidthFirstValue = true;
                        CardFrontTextureWidthFirstValue = 100;
                        if (interpolationValue < 1)
                        {
                            this.CardFront.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CardFront.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.CardBack.Animate = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CardBack.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CardBack.SourceFile", "cardback.png");
                        }
                        setCardBackTextureHeightSecondValue = true;
                        CardBackTextureHeightSecondValue = 1755;
                        setCardBackTextureLeftSecondValue = true;
                        CardBackTextureLeftSecondValue = 0;
                        setCardBackTextureWidthSecondValue = true;
                        CardBackTextureWidthSecondValue = 4096;
                        if (interpolationValue >= 1)
                        {
                            this.CardBack.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CardFront.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CardFront.SourceFile", "modern_13x4x560x780.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CardFront.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setCardFrontTextureHeightSecondValue = true;
                        CardFrontTextureHeightSecondValue = 139;
                        setCardFrontTextureLeftSecondValue = true;
                        CardFrontTextureLeftSecondValue = 0;
                        setCardFrontTextureTopSecondValue = true;
                        CardFrontTextureTopSecondValue = 0;
                        setCardFrontTextureWidthSecondValue = true;
                        CardFrontTextureWidthSecondValue = 100;
                        if (interpolationValue >= 1)
                        {
                            this.CardFront.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CardFront.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        break;
                }
                if (setCardBackTextureHeightFirstValue && setCardBackTextureHeightSecondValue)
                {
                    CardBack.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(CardBackTextureHeightFirstValue* (1 - interpolationValue) + CardBackTextureHeightSecondValue * interpolationValue);
                }
                if (setCardBackTextureLeftFirstValue && setCardBackTextureLeftSecondValue)
                {
                    CardBack.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(CardBackTextureLeftFirstValue* (1 - interpolationValue) + CardBackTextureLeftSecondValue * interpolationValue);
                }
                if (setCardBackTextureWidthFirstValue && setCardBackTextureWidthSecondValue)
                {
                    CardBack.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(CardBackTextureWidthFirstValue* (1 - interpolationValue) + CardBackTextureWidthSecondValue * interpolationValue);
                }
                if (setCardFrontTextureHeightFirstValue && setCardFrontTextureHeightSecondValue)
                {
                    CardFront.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(CardFrontTextureHeightFirstValue* (1 - interpolationValue) + CardFrontTextureHeightSecondValue * interpolationValue);
                }
                if (setCardFrontTextureLeftFirstValue && setCardFrontTextureLeftSecondValue)
                {
                    CardFront.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(CardFrontTextureLeftFirstValue* (1 - interpolationValue) + CardFrontTextureLeftSecondValue * interpolationValue);
                }
                if (setCardFrontTextureTopFirstValue && setCardFrontTextureTopSecondValue)
                {
                    CardFront.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(CardFrontTextureTopFirstValue* (1 - interpolationValue) + CardFrontTextureTopSecondValue * interpolationValue);
                }
                if (setCardFrontTextureWidthFirstValue && setCardFrontTextureWidthSecondValue)
                {
                    CardFront.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(CardFrontTextureWidthFirstValue* (1 - interpolationValue) + CardFrontTextureWidthSecondValue * interpolationValue);
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.PlayingCardRuntime.VariableState fromState,Frbcon2019.GumRuntimes.PlayingCardRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Animate",
                            Type = "bool",
                            Value = CardBack.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Height Units",
                            Type = "DimensionUnitType",
                            Value = CardBack.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.SourceFile",
                            Type = "string",
                            Value = CardBack.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Texture Height",
                            Type = "int",
                            Value = CardBack.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Texture Left",
                            Type = "int",
                            Value = CardBack.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Texture Width",
                            Type = "int",
                            Value = CardBack.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Width Units",
                            Type = "DimensionUnitType",
                            Value = CardBack.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Height Units",
                            Type = "DimensionUnitType",
                            Value = CardFront.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.SourceFile",
                            Type = "string",
                            Value = CardFront.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Address",
                            Type = "TextureAddress",
                            Value = CardFront.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Height",
                            Type = "int",
                            Value = CardFront.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Left",
                            Type = "int",
                            Value = CardFront.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Top",
                            Type = "int",
                            Value = CardFront.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Width",
                            Type = "int",
                            Value = CardFront.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Visible",
                            Type = "bool",
                            Value = CardFront.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Width Units",
                            Type = "DimensionUnitType",
                            Value = CardFront.WidthUnits
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
                            Name = "Width",
                            Type = "float",
                            Value = Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Animate",
                            Type = "bool",
                            Value = CardBack.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Height Units",
                            Type = "DimensionUnitType",
                            Value = CardBack.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.SourceFile",
                            Type = "string",
                            Value = CardBack.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Texture Height",
                            Type = "int",
                            Value = CardBack.TextureHeight + 1755
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Texture Left",
                            Type = "int",
                            Value = CardBack.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Texture Width",
                            Type = "int",
                            Value = CardBack.TextureWidth + 4096
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardBack.Width Units",
                            Type = "DimensionUnitType",
                            Value = CardBack.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Height Units",
                            Type = "DimensionUnitType",
                            Value = CardFront.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.SourceFile",
                            Type = "string",
                            Value = CardFront.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Address",
                            Type = "TextureAddress",
                            Value = CardFront.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Height",
                            Type = "int",
                            Value = CardFront.TextureHeight + 139
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Left",
                            Type = "int",
                            Value = CardFront.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Top",
                            Type = "int",
                            Value = CardFront.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Texture Width",
                            Type = "int",
                            Value = CardFront.TextureWidth + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Visible",
                            Type = "bool",
                            Value = CardFront.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CardFront.Width Units",
                            Type = "DimensionUnitType",
                            Value = CardFront.WidthUnits
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
            private Frbcon2019.GumRuntimes.SpriteRuntime CardBack { get; set; }
            private Frbcon2019.GumRuntimes.SpriteRuntime CardFront { get; set; }
            public Gum.Managers.TextureAddress CardDisplayTexture_Address
            {
                get
                {
                    return CardBack.TextureAddress;
                }
                set
                {
                    if (CardBack.TextureAddress != value)
                    {
                        CardBack.TextureAddress = value;
                        CardDisplayTextureAddressChanged?.Invoke(this, null);
                    }
                }
            }
            public int CardDisplayTextureTop
            {
                get
                {
                    return CardBack.TextureTop;
                }
                set
                {
                    if (CardBack.TextureTop != value)
                    {
                        CardBack.TextureTop = value;
                        CardDisplayTextureTopChanged?.Invoke(this, null);
                    }
                }
            }
            public int CardFrontTextureLeft
            {
                get
                {
                    return CardFront.TextureLeft;
                }
                set
                {
                    if (CardFront.TextureLeft != value)
                    {
                        CardFront.TextureLeft = value;
                        CardFrontTextureLeftChanged?.Invoke(this, null);
                    }
                }
            }
            public int CardFrontTextureTop
            {
                get
                {
                    return CardFront.TextureTop;
                }
                set
                {
                    if (CardFront.TextureTop != value)
                    {
                        CardFront.TextureTop = value;
                        CardFrontTextureTopChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler CardDisplayTextureAddressChanged;
            public event System.EventHandler CardDisplayTextureTopChanged;
            public event System.EventHandler CardFrontTextureLeftChanged;
            public event System.EventHandler CardFrontTextureTopChanged;
            public PlayingCardRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "PlayingCard");
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
                CardBack = this.GetGraphicalUiElementByName("CardBack") as Frbcon2019.GumRuntimes.SpriteRuntime;
                CardFront = this.GetGraphicalUiElementByName("CardFront") as Frbcon2019.GumRuntimes.SpriteRuntime;
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
