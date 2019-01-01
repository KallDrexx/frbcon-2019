    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class MiniGameBaseGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum GameState
            {
                InstructionScreen,
                GameActive
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            GameState? mCurrentGameStateState;
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
                            ContentBlocker.Blue = 0;
                            ContentBlocker.Green = 0;
                            ContentBlocker.Height = 0f;
                            ContentBlocker.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContentBlocker.Red = 0;
                            ContentBlocker.Visible = false;
                            ContentBlocker.Width = 0f;
                            ContentBlocker.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContentBlocker.X = 0f;
                            ContentBlocker.Y = 0f;
                            Instructions.Height = 0f;
                            Instructions.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Instructions.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Instructions.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                            Instructions.Width = 0f;
                            Instructions.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SplashContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            SplashContainer.Height = 0f;
                            SplashContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SplashContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContentBlocker");
                            SplashContainer.Width = 0f;
                            SplashContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SplashContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SplashContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Spacer.Height = 50f;
                            Spacer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                            Spacer.Width = 0f;
                            InstructionsTimeLeftText.Height = 0f;
                            InstructionsTimeLeftText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                            InstructionsTimeLeftText.Width = 0f;
                            MinigameUI.Height = 100f;
                            MinigameUI.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MinigameUI.Visible = false;
                            MinigameUI.Width = 100f;
                            MinigameUI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                            TextInstance.Text = "Gameplay occurs here";
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance1.Height = 0f;
                            TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                            TextInstance1.Text = "Time Remaining:\n";
                            TextInstance1.Width = 0f;
                            TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            TimerDisplay.Height = 0f;
                            TimerDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                            TimerDisplay.Width = 0f;
                            TimerDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimerDisplay.X = 50f;
                            TimerDisplay.Y = -25f;
                            TimerDisplay.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            GameTimeLeft.Height = 0f;
                            GameTimeLeft.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                            GameTimeLeft.Width = 0f;
                            break;
                    }
                }
            }
            public GameState? CurrentGameStateState
            {
                get
                {
                    return mCurrentGameStateState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentGameStateState = value;
                        switch(mCurrentGameStateState)
                        {
                            case  GameState.InstructionScreen:
                                ContentBlocker.Visible = true;
                                MinigameUI.Visible = false;
                                break;
                            case  GameState.GameActive:
                                ContentBlocker.Visible = false;
                                MinigameUI.Visible = true;
                                break;
                        }
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
                bool setContentBlockerBlueFirstValue = false;
                bool setContentBlockerBlueSecondValue = false;
                int ContentBlockerBlueFirstValue= 0;
                int ContentBlockerBlueSecondValue= 0;
                bool setContentBlockerGreenFirstValue = false;
                bool setContentBlockerGreenSecondValue = false;
                int ContentBlockerGreenFirstValue= 0;
                int ContentBlockerGreenSecondValue= 0;
                bool setContentBlockerHeightFirstValue = false;
                bool setContentBlockerHeightSecondValue = false;
                float ContentBlockerHeightFirstValue= 0;
                float ContentBlockerHeightSecondValue= 0;
                bool setContentBlockerRedFirstValue = false;
                bool setContentBlockerRedSecondValue = false;
                int ContentBlockerRedFirstValue= 0;
                int ContentBlockerRedSecondValue= 0;
                bool setContentBlockerWidthFirstValue = false;
                bool setContentBlockerWidthSecondValue = false;
                float ContentBlockerWidthFirstValue= 0;
                float ContentBlockerWidthSecondValue= 0;
                bool setContentBlockerXFirstValue = false;
                bool setContentBlockerXSecondValue = false;
                float ContentBlockerXFirstValue= 0;
                float ContentBlockerXSecondValue= 0;
                bool setContentBlockerYFirstValue = false;
                bool setContentBlockerYSecondValue = false;
                float ContentBlockerYFirstValue= 0;
                float ContentBlockerYSecondValue= 0;
                bool setGameTimeLeftHeightFirstValue = false;
                bool setGameTimeLeftHeightSecondValue = false;
                float GameTimeLeftHeightFirstValue= 0;
                float GameTimeLeftHeightSecondValue= 0;
                bool setGameTimeLeftWidthFirstValue = false;
                bool setGameTimeLeftWidthSecondValue = false;
                float GameTimeLeftWidthFirstValue= 0;
                float GameTimeLeftWidthSecondValue= 0;
                bool setInstructionsHeightFirstValue = false;
                bool setInstructionsHeightSecondValue = false;
                float InstructionsHeightFirstValue= 0;
                float InstructionsHeightSecondValue= 0;
                bool setInstructionsWidthFirstValue = false;
                bool setInstructionsWidthSecondValue = false;
                float InstructionsWidthFirstValue= 0;
                float InstructionsWidthSecondValue= 0;
                bool setInstructionsTimeLeftTextHeightFirstValue = false;
                bool setInstructionsTimeLeftTextHeightSecondValue = false;
                float InstructionsTimeLeftTextHeightFirstValue= 0;
                float InstructionsTimeLeftTextHeightSecondValue= 0;
                bool setInstructionsTimeLeftTextWidthFirstValue = false;
                bool setInstructionsTimeLeftTextWidthSecondValue = false;
                float InstructionsTimeLeftTextWidthFirstValue= 0;
                float InstructionsTimeLeftTextWidthSecondValue= 0;
                bool setMinigameUIHeightFirstValue = false;
                bool setMinigameUIHeightSecondValue = false;
                float MinigameUIHeightFirstValue= 0;
                float MinigameUIHeightSecondValue= 0;
                bool setMinigameUIWidthFirstValue = false;
                bool setMinigameUIWidthSecondValue = false;
                float MinigameUIWidthFirstValue= 0;
                float MinigameUIWidthSecondValue= 0;
                bool setSpacerHeightFirstValue = false;
                bool setSpacerHeightSecondValue = false;
                float SpacerHeightFirstValue= 0;
                float SpacerHeightSecondValue= 0;
                bool setSpacerWidthFirstValue = false;
                bool setSpacerWidthSecondValue = false;
                float SpacerWidthFirstValue= 0;
                float SpacerWidthSecondValue= 0;
                bool setSplashContainerHeightFirstValue = false;
                bool setSplashContainerHeightSecondValue = false;
                float SplashContainerHeightFirstValue= 0;
                float SplashContainerHeightSecondValue= 0;
                bool setSplashContainerWidthFirstValue = false;
                bool setSplashContainerWidthSecondValue = false;
                float SplashContainerWidthFirstValue= 0;
                float SplashContainerWidthSecondValue= 0;
                bool setTextInstance1HeightFirstValue = false;
                bool setTextInstance1HeightSecondValue = false;
                float TextInstance1HeightFirstValue= 0;
                float TextInstance1HeightSecondValue= 0;
                bool setTextInstance1WidthFirstValue = false;
                bool setTextInstance1WidthSecondValue = false;
                float TextInstance1WidthFirstValue= 0;
                float TextInstance1WidthSecondValue= 0;
                bool setTimerDisplayHeightFirstValue = false;
                bool setTimerDisplayHeightSecondValue = false;
                float TimerDisplayHeightFirstValue= 0;
                float TimerDisplayHeightSecondValue= 0;
                bool setTimerDisplayWidthFirstValue = false;
                bool setTimerDisplayWidthSecondValue = false;
                float TimerDisplayWidthFirstValue= 0;
                float TimerDisplayWidthSecondValue= 0;
                bool setTimerDisplayXFirstValue = false;
                bool setTimerDisplayXSecondValue = false;
                float TimerDisplayXFirstValue= 0;
                float TimerDisplayXSecondValue= 0;
                bool setTimerDisplayYFirstValue = false;
                bool setTimerDisplayYSecondValue = false;
                float TimerDisplayYFirstValue= 0;
                float TimerDisplayYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setContentBlockerBlueFirstValue = true;
                        ContentBlockerBlueFirstValue = 0;
                        setContentBlockerGreenFirstValue = true;
                        ContentBlockerGreenFirstValue = 0;
                        setContentBlockerHeightFirstValue = true;
                        ContentBlockerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContentBlocker.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContentBlockerRedFirstValue = true;
                        ContentBlockerRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ContentBlocker.Visible = false;
                        }
                        setContentBlockerWidthFirstValue = true;
                        ContentBlockerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContentBlocker.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContentBlockerXFirstValue = true;
                        ContentBlockerXFirstValue = 0f;
                        setContentBlockerYFirstValue = true;
                        ContentBlockerYFirstValue = 0f;
                        setGameTimeLeftHeightFirstValue = true;
                        GameTimeLeftHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GameTimeLeft.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        setGameTimeLeftWidthFirstValue = true;
                        GameTimeLeftWidthFirstValue = 0f;
                        setInstructionsHeightFirstValue = true;
                        InstructionsHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Instructions.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Instructions.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Instructions.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                        }
                        setInstructionsWidthFirstValue = true;
                        InstructionsWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Instructions.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setInstructionsTimeLeftTextHeightFirstValue = true;
                        InstructionsTimeLeftTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InstructionsTimeLeftText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                        }
                        setInstructionsTimeLeftTextWidthFirstValue = true;
                        InstructionsTimeLeftTextWidthFirstValue = 0f;
                        setMinigameUIHeightFirstValue = true;
                        MinigameUIHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MinigameUI.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MinigameUI.Visible = false;
                        }
                        setMinigameUIWidthFirstValue = true;
                        MinigameUIWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MinigameUI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSpacerHeightFirstValue = true;
                        SpacerHeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.Spacer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                        }
                        setSpacerWidthFirstValue = true;
                        SpacerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SplashContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setSplashContainerHeightFirstValue = true;
                        SplashContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SplashContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SplashContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContentBlocker");
                        }
                        setSplashContainerWidthFirstValue = true;
                        SplashContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SplashContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SplashContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SplashContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Gameplay occurs here";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstance1HeightFirstValue = true;
                        TextInstance1HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "Time Remaining:\n";
                        }
                        setTextInstance1WidthFirstValue = true;
                        TextInstance1WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTimerDisplayHeightFirstValue = true;
                        TimerDisplayHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        setTimerDisplayWidthFirstValue = true;
                        TimerDisplayWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTimerDisplayXFirstValue = true;
                        TimerDisplayXFirstValue = 50f;
                        setTimerDisplayYFirstValue = true;
                        TimerDisplayYFirstValue = -25f;
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setContentBlockerBlueSecondValue = true;
                        ContentBlockerBlueSecondValue = 0;
                        setContentBlockerGreenSecondValue = true;
                        ContentBlockerGreenSecondValue = 0;
                        setContentBlockerHeightSecondValue = true;
                        ContentBlockerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContentBlocker.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContentBlockerRedSecondValue = true;
                        ContentBlockerRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ContentBlocker.Visible = false;
                        }
                        setContentBlockerWidthSecondValue = true;
                        ContentBlockerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContentBlocker.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContentBlockerXSecondValue = true;
                        ContentBlockerXSecondValue = 0f;
                        setContentBlockerYSecondValue = true;
                        ContentBlockerYSecondValue = 0f;
                        setGameTimeLeftHeightSecondValue = true;
                        GameTimeLeftHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GameTimeLeft.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        setGameTimeLeftWidthSecondValue = true;
                        GameTimeLeftWidthSecondValue = 0f;
                        setInstructionsHeightSecondValue = true;
                        InstructionsHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Instructions.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Instructions.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Instructions.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                        }
                        setInstructionsWidthSecondValue = true;
                        InstructionsWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Instructions.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setInstructionsTimeLeftTextHeightSecondValue = true;
                        InstructionsTimeLeftTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsTimeLeftText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                        }
                        setInstructionsTimeLeftTextWidthSecondValue = true;
                        InstructionsTimeLeftTextWidthSecondValue = 0f;
                        setMinigameUIHeightSecondValue = true;
                        MinigameUIHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MinigameUI.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MinigameUI.Visible = false;
                        }
                        setMinigameUIWidthSecondValue = true;
                        MinigameUIWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MinigameUI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSpacerHeightSecondValue = true;
                        SpacerHeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.Spacer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SplashContainer");
                        }
                        setSpacerWidthSecondValue = true;
                        SpacerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SplashContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setSplashContainerHeightSecondValue = true;
                        SplashContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SplashContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SplashContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContentBlocker");
                        }
                        setSplashContainerWidthSecondValue = true;
                        SplashContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SplashContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SplashContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SplashContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Gameplay occurs here";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstance1HeightSecondValue = true;
                        TextInstance1HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "Time Remaining:\n";
                        }
                        setTextInstance1WidthSecondValue = true;
                        TextInstance1WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTimerDisplayHeightSecondValue = true;
                        TimerDisplayHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        setTimerDisplayWidthSecondValue = true;
                        TimerDisplayWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTimerDisplayXSecondValue = true;
                        TimerDisplayXSecondValue = 50f;
                        setTimerDisplayYSecondValue = true;
                        TimerDisplayYSecondValue = -25f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                if (setContentBlockerBlueFirstValue && setContentBlockerBlueSecondValue)
                {
                    ContentBlocker.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ContentBlockerBlueFirstValue* (1 - interpolationValue) + ContentBlockerBlueSecondValue * interpolationValue);
                }
                if (setContentBlockerGreenFirstValue && setContentBlockerGreenSecondValue)
                {
                    ContentBlocker.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ContentBlockerGreenFirstValue* (1 - interpolationValue) + ContentBlockerGreenSecondValue * interpolationValue);
                }
                if (setContentBlockerHeightFirstValue && setContentBlockerHeightSecondValue)
                {
                    ContentBlocker.Height = ContentBlockerHeightFirstValue * (1 - interpolationValue) + ContentBlockerHeightSecondValue * interpolationValue;
                }
                if (setContentBlockerRedFirstValue && setContentBlockerRedSecondValue)
                {
                    ContentBlocker.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ContentBlockerRedFirstValue* (1 - interpolationValue) + ContentBlockerRedSecondValue * interpolationValue);
                }
                if (setContentBlockerWidthFirstValue && setContentBlockerWidthSecondValue)
                {
                    ContentBlocker.Width = ContentBlockerWidthFirstValue * (1 - interpolationValue) + ContentBlockerWidthSecondValue * interpolationValue;
                }
                if (setContentBlockerXFirstValue && setContentBlockerXSecondValue)
                {
                    ContentBlocker.X = ContentBlockerXFirstValue * (1 - interpolationValue) + ContentBlockerXSecondValue * interpolationValue;
                }
                if (setContentBlockerYFirstValue && setContentBlockerYSecondValue)
                {
                    ContentBlocker.Y = ContentBlockerYFirstValue * (1 - interpolationValue) + ContentBlockerYSecondValue * interpolationValue;
                }
                if (setGameTimeLeftHeightFirstValue && setGameTimeLeftHeightSecondValue)
                {
                    GameTimeLeft.Height = GameTimeLeftHeightFirstValue * (1 - interpolationValue) + GameTimeLeftHeightSecondValue * interpolationValue;
                }
                if (setGameTimeLeftWidthFirstValue && setGameTimeLeftWidthSecondValue)
                {
                    GameTimeLeft.Width = GameTimeLeftWidthFirstValue * (1 - interpolationValue) + GameTimeLeftWidthSecondValue * interpolationValue;
                }
                if (setInstructionsHeightFirstValue && setInstructionsHeightSecondValue)
                {
                    Instructions.Height = InstructionsHeightFirstValue * (1 - interpolationValue) + InstructionsHeightSecondValue * interpolationValue;
                }
                if (setInstructionsWidthFirstValue && setInstructionsWidthSecondValue)
                {
                    Instructions.Width = InstructionsWidthFirstValue * (1 - interpolationValue) + InstructionsWidthSecondValue * interpolationValue;
                }
                if (setInstructionsTimeLeftTextHeightFirstValue && setInstructionsTimeLeftTextHeightSecondValue)
                {
                    InstructionsTimeLeftText.Height = InstructionsTimeLeftTextHeightFirstValue * (1 - interpolationValue) + InstructionsTimeLeftTextHeightSecondValue * interpolationValue;
                }
                if (setInstructionsTimeLeftTextWidthFirstValue && setInstructionsTimeLeftTextWidthSecondValue)
                {
                    InstructionsTimeLeftText.Width = InstructionsTimeLeftTextWidthFirstValue * (1 - interpolationValue) + InstructionsTimeLeftTextWidthSecondValue * interpolationValue;
                }
                if (setMinigameUIHeightFirstValue && setMinigameUIHeightSecondValue)
                {
                    MinigameUI.Height = MinigameUIHeightFirstValue * (1 - interpolationValue) + MinigameUIHeightSecondValue * interpolationValue;
                }
                if (setMinigameUIWidthFirstValue && setMinigameUIWidthSecondValue)
                {
                    MinigameUI.Width = MinigameUIWidthFirstValue * (1 - interpolationValue) + MinigameUIWidthSecondValue * interpolationValue;
                }
                if (setSpacerHeightFirstValue && setSpacerHeightSecondValue)
                {
                    Spacer.Height = SpacerHeightFirstValue * (1 - interpolationValue) + SpacerHeightSecondValue * interpolationValue;
                }
                if (setSpacerWidthFirstValue && setSpacerWidthSecondValue)
                {
                    Spacer.Width = SpacerWidthFirstValue * (1 - interpolationValue) + SpacerWidthSecondValue * interpolationValue;
                }
                if (setSplashContainerHeightFirstValue && setSplashContainerHeightSecondValue)
                {
                    SplashContainer.Height = SplashContainerHeightFirstValue * (1 - interpolationValue) + SplashContainerHeightSecondValue * interpolationValue;
                }
                if (setSplashContainerWidthFirstValue && setSplashContainerWidthSecondValue)
                {
                    SplashContainer.Width = SplashContainerWidthFirstValue * (1 - interpolationValue) + SplashContainerWidthSecondValue * interpolationValue;
                }
                if (setTextInstance1HeightFirstValue && setTextInstance1HeightSecondValue)
                {
                    TextInstance1.Height = TextInstance1HeightFirstValue * (1 - interpolationValue) + TextInstance1HeightSecondValue * interpolationValue;
                }
                if (setTextInstance1WidthFirstValue && setTextInstance1WidthSecondValue)
                {
                    TextInstance1.Width = TextInstance1WidthFirstValue * (1 - interpolationValue) + TextInstance1WidthSecondValue * interpolationValue;
                }
                if (setTimerDisplayHeightFirstValue && setTimerDisplayHeightSecondValue)
                {
                    TimerDisplay.Height = TimerDisplayHeightFirstValue * (1 - interpolationValue) + TimerDisplayHeightSecondValue * interpolationValue;
                }
                if (setTimerDisplayWidthFirstValue && setTimerDisplayWidthSecondValue)
                {
                    TimerDisplay.Width = TimerDisplayWidthFirstValue * (1 - interpolationValue) + TimerDisplayWidthSecondValue * interpolationValue;
                }
                if (setTimerDisplayXFirstValue && setTimerDisplayXSecondValue)
                {
                    TimerDisplay.X = TimerDisplayXFirstValue * (1 - interpolationValue) + TimerDisplayXSecondValue * interpolationValue;
                }
                if (setTimerDisplayYFirstValue && setTimerDisplayYSecondValue)
                {
                    TimerDisplay.Y = TimerDisplayYFirstValue * (1 - interpolationValue) + TimerDisplayYSecondValue * interpolationValue;
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
            public void InterpolateBetween (GameState firstState, GameState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  GameState.InstructionScreen:
                        if (interpolationValue < 1)
                        {
                            this.ContentBlocker.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MinigameUI.Visible = false;
                        }
                        break;
                    case  GameState.GameActive:
                        if (interpolationValue < 1)
                        {
                            this.ContentBlocker.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MinigameUI.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  GameState.InstructionScreen:
                        if (interpolationValue >= 1)
                        {
                            this.ContentBlocker.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MinigameUI.Visible = false;
                        }
                        break;
                    case  GameState.GameActive:
                        if (interpolationValue >= 1)
                        {
                            this.ContentBlocker.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MinigameUI.Visible = true;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentGameStateState = firstState;
                }
                else
                {
                    mCurrentGameStateState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime.VariableState fromState,Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime.GameState fromState,Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime.GameState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GameState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "GameState").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentGameStateState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (GameState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentGameStateState = toState;
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
                            Name = "ContentBlocker.Blue",
                            Type = "int",
                            Value = ContentBlocker.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Green",
                            Type = "int",
                            Value = ContentBlocker.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Height",
                            Type = "float",
                            Value = ContentBlocker.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContentBlocker.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Red",
                            Type = "int",
                            Value = ContentBlocker.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Visible",
                            Type = "bool",
                            Value = ContentBlocker.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Width",
                            Type = "float",
                            Value = ContentBlocker.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContentBlocker.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.X",
                            Type = "float",
                            Value = ContentBlocker.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Y",
                            Type = "float",
                            Value = ContentBlocker.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Height",
                            Type = "float",
                            Value = Instructions.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Height Units",
                            Type = "DimensionUnitType",
                            Value = Instructions.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Instructions.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Parent",
                            Type = "string",
                            Value = Instructions.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Width",
                            Type = "float",
                            Value = Instructions.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Width Units",
                            Type = "DimensionUnitType",
                            Value = Instructions.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = SplashContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Height",
                            Type = "float",
                            Value = SplashContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = SplashContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Parent",
                            Type = "string",
                            Value = SplashContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Width",
                            Type = "float",
                            Value = SplashContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = SplashContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.X Units",
                            Type = "PositionUnitType",
                            Value = SplashContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = SplashContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Spacer.Height",
                            Type = "float",
                            Value = Spacer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Spacer.Parent",
                            Type = "string",
                            Value = Spacer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Spacer.Width",
                            Type = "float",
                            Value = Spacer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsTimeLeftText.Height",
                            Type = "float",
                            Value = InstructionsTimeLeftText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsTimeLeftText.Parent",
                            Type = "string",
                            Value = InstructionsTimeLeftText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsTimeLeftText.Width",
                            Type = "float",
                            Value = InstructionsTimeLeftText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Height",
                            Type = "float",
                            Value = MinigameUI.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Height Units",
                            Type = "DimensionUnitType",
                            Value = MinigameUI.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Visible",
                            Type = "bool",
                            Value = MinigameUI.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Width",
                            Type = "float",
                            Value = MinigameUI.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Width Units",
                            Type = "DimensionUnitType",
                            Value = MinigameUI.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
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
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
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
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TimerDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Height",
                            Type = "float",
                            Value = TimerDisplay.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimerDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Parent",
                            Type = "string",
                            Value = TimerDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Width",
                            Type = "float",
                            Value = TimerDisplay.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = TimerDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.X",
                            Type = "float",
                            Value = TimerDisplay.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Y",
                            Type = "float",
                            Value = TimerDisplay.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Y Units",
                            Type = "PositionUnitType",
                            Value = TimerDisplay.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameTimeLeft.Height",
                            Type = "float",
                            Value = GameTimeLeft.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameTimeLeft.Parent",
                            Type = "string",
                            Value = GameTimeLeft.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameTimeLeft.Width",
                            Type = "float",
                            Value = GameTimeLeft.Width
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
                            Name = "ContentBlocker.Blue",
                            Type = "int",
                            Value = ContentBlocker.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Green",
                            Type = "int",
                            Value = ContentBlocker.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Height",
                            Type = "float",
                            Value = ContentBlocker.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContentBlocker.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Red",
                            Type = "int",
                            Value = ContentBlocker.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Visible",
                            Type = "bool",
                            Value = ContentBlocker.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Width",
                            Type = "float",
                            Value = ContentBlocker.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContentBlocker.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.X",
                            Type = "float",
                            Value = ContentBlocker.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Y",
                            Type = "float",
                            Value = ContentBlocker.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Height",
                            Type = "float",
                            Value = Instructions.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Height Units",
                            Type = "DimensionUnitType",
                            Value = Instructions.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Instructions.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Parent",
                            Type = "string",
                            Value = Instructions.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Width",
                            Type = "float",
                            Value = Instructions.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Instructions.Width Units",
                            Type = "DimensionUnitType",
                            Value = Instructions.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = SplashContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Height",
                            Type = "float",
                            Value = SplashContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = SplashContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Parent",
                            Type = "string",
                            Value = SplashContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Width",
                            Type = "float",
                            Value = SplashContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = SplashContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.X Units",
                            Type = "PositionUnitType",
                            Value = SplashContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SplashContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = SplashContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Spacer.Height",
                            Type = "float",
                            Value = Spacer.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Spacer.Parent",
                            Type = "string",
                            Value = Spacer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Spacer.Width",
                            Type = "float",
                            Value = Spacer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsTimeLeftText.Height",
                            Type = "float",
                            Value = InstructionsTimeLeftText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsTimeLeftText.Parent",
                            Type = "string",
                            Value = InstructionsTimeLeftText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsTimeLeftText.Width",
                            Type = "float",
                            Value = InstructionsTimeLeftText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Height",
                            Type = "float",
                            Value = MinigameUI.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Height Units",
                            Type = "DimensionUnitType",
                            Value = MinigameUI.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Visible",
                            Type = "bool",
                            Value = MinigameUI.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Width",
                            Type = "float",
                            Value = MinigameUI.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Width Units",
                            Type = "DimensionUnitType",
                            Value = MinigameUI.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
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
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height + 0f
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
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TimerDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Height",
                            Type = "float",
                            Value = TimerDisplay.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = TimerDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Parent",
                            Type = "string",
                            Value = TimerDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Width",
                            Type = "float",
                            Value = TimerDisplay.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = TimerDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.X",
                            Type = "float",
                            Value = TimerDisplay.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Y",
                            Type = "float",
                            Value = TimerDisplay.Y + -25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerDisplay.Y Units",
                            Type = "PositionUnitType",
                            Value = TimerDisplay.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameTimeLeft.Height",
                            Type = "float",
                            Value = GameTimeLeft.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameTimeLeft.Parent",
                            Type = "string",
                            Value = GameTimeLeft.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameTimeLeft.Width",
                            Type = "float",
                            Value = GameTimeLeft.Width + 0f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (GameState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  GameState.InstructionScreen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Visible",
                            Type = "bool",
                            Value = ContentBlocker.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Visible",
                            Type = "bool",
                            Value = MinigameUI.Visible
                        }
                        );
                        break;
                    case  GameState.GameActive:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Visible",
                            Type = "bool",
                            Value = ContentBlocker.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Visible",
                            Type = "bool",
                            Value = MinigameUI.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (GameState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  GameState.InstructionScreen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Visible",
                            Type = "bool",
                            Value = ContentBlocker.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Visible",
                            Type = "bool",
                            Value = MinigameUI.Visible
                        }
                        );
                        break;
                    case  GameState.GameActive:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContentBlocker.Visible",
                            Type = "bool",
                            Value = ContentBlocker.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinigameUI.Visible",
                            Type = "bool",
                            Value = MinigameUI.Visible
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
                    else if (category.Name == "GameState")
                    {
                        if(state.Name == "InstructionScreen") this.mCurrentGameStateState = GameState.InstructionScreen;
                        if(state.Name == "GameActive") this.mCurrentGameStateState = GameState.GameActive;
                    }
                }
                base.ApplyState(state);
            }
            public Frbcon2019.GumRuntimes.ColoredRectangleRuntime ContentBlocker { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime Instructions { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime SplashContainer { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime Spacer { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime InstructionsTimeLeftText { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime MinigameUI { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime TimerDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime GameTimeLeft { get; set; }
            public string GameTimeLeftText
            {
                get
                {
                    return GameTimeLeft.Text;
                }
                set
                {
                    if (GameTimeLeft.Text != value)
                    {
                        GameTimeLeft.Text = value;
                        GameTimeLeftTextChanged?.Invoke(this, null);
                    }
                }
            }
            public string TestText
            {
                get
                {
                    return Instructions.Text;
                }
                set
                {
                    if (Instructions.Text != value)
                    {
                        Instructions.Text = value;
                        TestTextChanged?.Invoke(this, null);
                    }
                }
            }
            public string TimerValueText
            {
                get
                {
                    return InstructionsTimeLeftText.Text;
                }
                set
                {
                    if (InstructionsTimeLeftText.Text != value)
                    {
                        InstructionsTimeLeftText.Text = value;
                        TimerValueTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler GameTimeLeftTextChanged;
            public event System.EventHandler TestTextChanged;
            public event System.EventHandler TimerValueTextChanged;
            public MiniGameBaseGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MiniGameBaseGum");
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
                ContentBlocker = this.GetGraphicalUiElementByName("ContentBlocker") as Frbcon2019.GumRuntimes.ColoredRectangleRuntime;
                Instructions = this.GetGraphicalUiElementByName("Instructions") as Frbcon2019.GumRuntimes.TextRuntime;
                SplashContainer = this.GetGraphicalUiElementByName("SplashContainer") as Frbcon2019.GumRuntimes.ContainerRuntime;
                Spacer = this.GetGraphicalUiElementByName("Spacer") as Frbcon2019.GumRuntimes.ContainerRuntime;
                InstructionsTimeLeftText = this.GetGraphicalUiElementByName("InstructionsTimeLeftText") as Frbcon2019.GumRuntimes.TextRuntime;
                MinigameUI = this.GetGraphicalUiElementByName("MinigameUI") as Frbcon2019.GumRuntimes.ContainerRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as Frbcon2019.GumRuntimes.TextRuntime;
                TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as Frbcon2019.GumRuntimes.TextRuntime;
                TimerDisplay = this.GetGraphicalUiElementByName("TimerDisplay") as Frbcon2019.GumRuntimes.ContainerRuntime;
                GameTimeLeft = this.GetGraphicalUiElementByName("GameTimeLeft") as Frbcon2019.GumRuntimes.TextRuntime;
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
