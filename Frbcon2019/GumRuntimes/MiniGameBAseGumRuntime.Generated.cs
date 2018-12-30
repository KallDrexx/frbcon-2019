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
                            ContentBlocker.Blue = 0;
                            ContentBlocker.Green = 0;
                            ContentBlocker.Height = 0f;
                            ContentBlocker.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContentBlocker.Red = 0;
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
                            MinigameUI.Width = 100f;
                            MinigameUI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                            TextInstance.Text = "Gameplay occurs here";
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance1.Height = 0f;
                            TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            TextInstance1.Text = "Time Remaining:\n";
                            TextInstance1.Width = 0f;
                            ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            ContainerInstance.Height = 0f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ContainerInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                            ContainerInstance.Width = 0f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ContainerInstance.X = 50f;
                            ContainerInstance.Y = -25f;
                            ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            GameTimeLeft.Height = 0f;
                            GameTimeLeft.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            GameTimeLeft.Width = 0f;
                            ButtonInstance.Blue = 255;
                            ButtonInstance.Green = 0;
                            ButtonInstance.Height = 109f;
                            ButtonInstance.LabelText = "Press Me";
                            ButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                            ButtonInstance.Red = 0;
                            ButtonInstance.Width = 274f;
                            ButtonInstance.X = 216f;
                            ButtonInstance.Y = 94f;
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
                bool setButtonInstanceBlueFirstValue = false;
                bool setButtonInstanceBlueSecondValue = false;
                int ButtonInstanceBlueFirstValue= 0;
                int ButtonInstanceBlueSecondValue= 0;
                bool setButtonInstanceGreenFirstValue = false;
                bool setButtonInstanceGreenSecondValue = false;
                int ButtonInstanceGreenFirstValue= 0;
                int ButtonInstanceGreenSecondValue= 0;
                bool setButtonInstanceHeightFirstValue = false;
                bool setButtonInstanceHeightSecondValue = false;
                float ButtonInstanceHeightFirstValue= 0;
                float ButtonInstanceHeightSecondValue= 0;
                bool setButtonInstanceRedFirstValue = false;
                bool setButtonInstanceRedSecondValue = false;
                int ButtonInstanceRedFirstValue= 0;
                int ButtonInstanceRedSecondValue= 0;
                bool setButtonInstanceWidthFirstValue = false;
                bool setButtonInstanceWidthSecondValue = false;
                float ButtonInstanceWidthFirstValue= 0;
                float ButtonInstanceWidthSecondValue= 0;
                bool setButtonInstanceXFirstValue = false;
                bool setButtonInstanceXSecondValue = false;
                float ButtonInstanceXFirstValue= 0;
                float ButtonInstanceXSecondValue= 0;
                bool setButtonInstanceYFirstValue = false;
                bool setButtonInstanceYSecondValue = false;
                float ButtonInstanceYFirstValue= 0;
                float ButtonInstanceYSecondValue= 0;
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
                switch(firstState)
                {
                    case  VariableState.Default:
                        setButtonInstanceBlueFirstValue = true;
                        ButtonInstanceBlueFirstValue = 255;
                        setButtonInstanceGreenFirstValue = true;
                        ButtonInstanceGreenFirstValue = 0;
                        setButtonInstanceHeightFirstValue = true;
                        ButtonInstanceHeightFirstValue = 109f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.LabelText = "Press Me";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        setButtonInstanceRedFirstValue = true;
                        ButtonInstanceRedFirstValue = 0;
                        setButtonInstanceWidthFirstValue = true;
                        ButtonInstanceWidthFirstValue = 274f;
                        setButtonInstanceXFirstValue = true;
                        ButtonInstanceXFirstValue = 216f;
                        setButtonInstanceYFirstValue = true;
                        ButtonInstanceYFirstValue = 94f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 50f;
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = -25f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
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
                            this.GameTimeLeft.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
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
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "Time Remaining:\n";
                        }
                        setTextInstance1WidthFirstValue = true;
                        TextInstance1WidthFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setButtonInstanceBlueSecondValue = true;
                        ButtonInstanceBlueSecondValue = 255;
                        setButtonInstanceGreenSecondValue = true;
                        ButtonInstanceGreenSecondValue = 0;
                        setButtonInstanceHeightSecondValue = true;
                        ButtonInstanceHeightSecondValue = 109f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.LabelText = "Press Me";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        setButtonInstanceRedSecondValue = true;
                        ButtonInstanceRedSecondValue = 0;
                        setButtonInstanceWidthSecondValue = true;
                        ButtonInstanceWidthSecondValue = 274f;
                        setButtonInstanceXSecondValue = true;
                        ButtonInstanceXSecondValue = 216f;
                        setButtonInstanceYSecondValue = true;
                        ButtonInstanceYSecondValue = 94f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MinigameUI");
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 50f;
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = -25f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
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
                            this.GameTimeLeft.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
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
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "Time Remaining:\n";
                        }
                        setTextInstance1WidthSecondValue = true;
                        TextInstance1WidthSecondValue = 0f;
                        break;
                }
                if (setButtonInstanceBlueFirstValue && setButtonInstanceBlueSecondValue)
                {
                    ButtonInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonInstanceBlueFirstValue* (1 - interpolationValue) + ButtonInstanceBlueSecondValue * interpolationValue);
                }
                if (setButtonInstanceGreenFirstValue && setButtonInstanceGreenSecondValue)
                {
                    ButtonInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonInstanceGreenFirstValue* (1 - interpolationValue) + ButtonInstanceGreenSecondValue * interpolationValue);
                }
                if (setButtonInstanceHeightFirstValue && setButtonInstanceHeightSecondValue)
                {
                    ButtonInstance.Height = ButtonInstanceHeightFirstValue * (1 - interpolationValue) + ButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setButtonInstanceRedFirstValue && setButtonInstanceRedSecondValue)
                {
                    ButtonInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonInstanceRedFirstValue* (1 - interpolationValue) + ButtonInstanceRedSecondValue * interpolationValue);
                }
                if (setButtonInstanceWidthFirstValue && setButtonInstanceWidthSecondValue)
                {
                    ButtonInstance.Width = ButtonInstanceWidthFirstValue * (1 - interpolationValue) + ButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setButtonInstanceXFirstValue && setButtonInstanceXSecondValue)
                {
                    ButtonInstance.X = ButtonInstanceXFirstValue * (1 - interpolationValue) + ButtonInstanceXSecondValue * interpolationValue;
                }
                if (setButtonInstanceYFirstValue && setButtonInstanceYSecondValue)
                {
                    ButtonInstance.Y = ButtonInstanceYFirstValue * (1 - interpolationValue) + ButtonInstanceYSecondValue * interpolationValue;
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
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                ButtonInstance.StopAnimations();
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
                            Name = "ContainerInstance.Parent",
                            Type = "string",
                            Value = ContainerInstance.Parent
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
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Blue",
                            Type = "int",
                            Value = ButtonInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Green",
                            Type = "int",
                            Value = ButtonInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Height",
                            Type = "float",
                            Value = ButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.LabelText",
                            Type = "string",
                            Value = ButtonInstance.LabelText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Parent",
                            Type = "string",
                            Value = ButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Red",
                            Type = "int",
                            Value = ButtonInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Width",
                            Type = "float",
                            Value = ButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X",
                            Type = "float",
                            Value = ButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Y",
                            Type = "float",
                            Value = ButtonInstance.Y
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
                            Value = ContainerInstance.Height + 0f
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
                            Name = "ContainerInstance.Parent",
                            Type = "string",
                            Value = ContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + 0f
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
                            Value = ContainerInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + -25f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Blue",
                            Type = "int",
                            Value = ButtonInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Green",
                            Type = "int",
                            Value = ButtonInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Height",
                            Type = "float",
                            Value = ButtonInstance.Height + 109f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.LabelText",
                            Type = "string",
                            Value = ButtonInstance.LabelText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Parent",
                            Type = "string",
                            Value = ButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Red",
                            Type = "int",
                            Value = ButtonInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Width",
                            Type = "float",
                            Value = ButtonInstance.Width + 274f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X",
                            Type = "float",
                            Value = ButtonInstance.X + 216f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Y",
                            Type = "float",
                            Value = ButtonInstance.Y + 94f
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
            public Frbcon2019.GumRuntimes.ColoredRectangleRuntime ContentBlocker { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime Instructions { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime SplashContainer { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime Spacer { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime InstructionsTimeLeftText { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime MinigameUI { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime GameTimeLeft { get; set; }
            public Frbcon2019.GumRuntimes.ButtonRuntime ButtonInstance { get; set; }
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
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as Frbcon2019.GumRuntimes.ContainerRuntime;
                GameTimeLeft = this.GetGraphicalUiElementByName("GameTimeLeft") as Frbcon2019.GumRuntimes.TextRuntime;
                ButtonInstance = this.GetGraphicalUiElementByName("ButtonInstance") as Frbcon2019.GumRuntimes.ButtonRuntime;
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
