    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class ScoreboardGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default,
                Win,
                Lose
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
                            LivesDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            LivesDisplay.Height = 0f;
                            LivesDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            LivesDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                            LivesDisplay.Width = 0f;
                            LivesDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.Height = 0f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesDisplay");
                            TextInstance.Text = "Lives:";
                            TextInstance.Width = 0f;
                            LivesValue.Height = 0f;
                            LivesValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesDisplay");
                            LivesValue.Text = "0";
                            LivesValue.Width = 0f;
                            LivesValue.X = 0f;
                            LivesValue.Y = 0f;
                            ScoreDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            ScoreDisplay.Height = 0f;
                            ScoreDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ScoreDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                            ScoreDisplay.Width = 0f;
                            ScoreDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ScoreLabel.Height = 0f;
                            ScoreLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ScoreLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScoreDisplay");
                            ScoreLabel.Text = "Score:";
                            ScoreLabel.Width = 0f;
                            ScoreValue.Height = 0f;
                            ScoreValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScoreDisplay");
                            ScoreValue.Width = 0f;
                            Data.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            Data.Height = 0f;
                            Data.Width = 0f;
                            Data.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            Data.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Data.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Data.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            DifficultyDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            DifficultyDisplay.Height = 0f;
                            DifficultyDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            DifficultyDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                            DifficultyDisplay.Width = 0f;
                            DifficultyDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            TimerDisplay.Height = 0f;
                            TimerDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                            TimerDisplay.Width = 0f;
                            TimerDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TimerLabel.Height = 0f;
                            TimerLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TimerLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                            TimerLabel.Text = "Time Left:";
                            TimerLabel.Width = 0f;
                            TimerValue.Height = 0f;
                            TimerValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                            TimerValue.Text = "0";
                            TimerValue.Width = 0f;
                            LivesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            LivesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            LivesContainer.Width = 100f;
                            LivesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LivesContainer.WrapsChildren = true;
                            LastGameResult.X = 360f;
                            LastGameResult.Y = 121f;
                            ConditionDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ConditionDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameResult");
                            ConditionDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance1.Height = 0f;
                            TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "DifficultyDisplay");
                            TextInstance1.Text = "Difficulty:";
                            TextInstance1.Width = 0f;
                            DifficultyValue.Height = 0f;
                            DifficultyValue.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            DifficultyValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "DifficultyDisplay");
                            DifficultyValue.Width = 0f;
                            DifficultyValue.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            break;
                        case  VariableState.Win:
                            ConditionDisplay.Blue = 179;
                            ConditionDisplay.Green = 222;
                            ConditionDisplay.Red = 245;
                            SetProperty("ConditionDisplay.SourceFile", "medallist.png");
                            break;
                        case  VariableState.Lose:
                            ConditionDisplay.Blue = 0;
                            ConditionDisplay.Green = 0;
                            ConditionDisplay.Red = 255;
                            SetProperty("ConditionDisplay.SourceFile", "dead-head.png");
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
                bool setDataHeightFirstValue = false;
                bool setDataHeightSecondValue = false;
                float DataHeightFirstValue= 0;
                float DataHeightSecondValue= 0;
                bool setDataWidthFirstValue = false;
                bool setDataWidthSecondValue = false;
                float DataWidthFirstValue= 0;
                float DataWidthSecondValue= 0;
                bool setDifficultyDisplayHeightFirstValue = false;
                bool setDifficultyDisplayHeightSecondValue = false;
                float DifficultyDisplayHeightFirstValue= 0;
                float DifficultyDisplayHeightSecondValue= 0;
                bool setDifficultyDisplayWidthFirstValue = false;
                bool setDifficultyDisplayWidthSecondValue = false;
                float DifficultyDisplayWidthFirstValue= 0;
                float DifficultyDisplayWidthSecondValue= 0;
                bool setDifficultyValueHeightFirstValue = false;
                bool setDifficultyValueHeightSecondValue = false;
                float DifficultyValueHeightFirstValue= 0;
                float DifficultyValueHeightSecondValue= 0;
                bool setDifficultyValueWidthFirstValue = false;
                bool setDifficultyValueWidthSecondValue = false;
                float DifficultyValueWidthFirstValue= 0;
                float DifficultyValueWidthSecondValue= 0;
                bool setLastGameResultXFirstValue = false;
                bool setLastGameResultXSecondValue = false;
                float LastGameResultXFirstValue= 0;
                float LastGameResultXSecondValue= 0;
                bool setLastGameResultYFirstValue = false;
                bool setLastGameResultYSecondValue = false;
                float LastGameResultYFirstValue= 0;
                float LastGameResultYSecondValue= 0;
                bool setLivesContainerWidthFirstValue = false;
                bool setLivesContainerWidthSecondValue = false;
                float LivesContainerWidthFirstValue= 0;
                float LivesContainerWidthSecondValue= 0;
                bool setLivesDisplayHeightFirstValue = false;
                bool setLivesDisplayHeightSecondValue = false;
                float LivesDisplayHeightFirstValue= 0;
                float LivesDisplayHeightSecondValue= 0;
                bool setLivesDisplayWidthFirstValue = false;
                bool setLivesDisplayWidthSecondValue = false;
                float LivesDisplayWidthFirstValue= 0;
                float LivesDisplayWidthSecondValue= 0;
                bool setLivesValueHeightFirstValue = false;
                bool setLivesValueHeightSecondValue = false;
                float LivesValueHeightFirstValue= 0;
                float LivesValueHeightSecondValue= 0;
                bool setLivesValueWidthFirstValue = false;
                bool setLivesValueWidthSecondValue = false;
                float LivesValueWidthFirstValue= 0;
                float LivesValueWidthSecondValue= 0;
                bool setLivesValueXFirstValue = false;
                bool setLivesValueXSecondValue = false;
                float LivesValueXFirstValue= 0;
                float LivesValueXSecondValue= 0;
                bool setLivesValueYFirstValue = false;
                bool setLivesValueYSecondValue = false;
                float LivesValueYFirstValue= 0;
                float LivesValueYSecondValue= 0;
                bool setScoreDisplayHeightFirstValue = false;
                bool setScoreDisplayHeightSecondValue = false;
                float ScoreDisplayHeightFirstValue= 0;
                float ScoreDisplayHeightSecondValue= 0;
                bool setScoreDisplayWidthFirstValue = false;
                bool setScoreDisplayWidthSecondValue = false;
                float ScoreDisplayWidthFirstValue= 0;
                float ScoreDisplayWidthSecondValue= 0;
                bool setScoreLabelHeightFirstValue = false;
                bool setScoreLabelHeightSecondValue = false;
                float ScoreLabelHeightFirstValue= 0;
                float ScoreLabelHeightSecondValue= 0;
                bool setScoreLabelWidthFirstValue = false;
                bool setScoreLabelWidthSecondValue = false;
                float ScoreLabelWidthFirstValue= 0;
                float ScoreLabelWidthSecondValue= 0;
                bool setScoreValueHeightFirstValue = false;
                bool setScoreValueHeightSecondValue = false;
                float ScoreValueHeightFirstValue= 0;
                float ScoreValueHeightSecondValue= 0;
                bool setScoreValueWidthFirstValue = false;
                bool setScoreValueWidthSecondValue = false;
                float ScoreValueWidthFirstValue= 0;
                float ScoreValueWidthSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
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
                bool setTimerLabelHeightFirstValue = false;
                bool setTimerLabelHeightSecondValue = false;
                float TimerLabelHeightFirstValue= 0;
                float TimerLabelHeightSecondValue= 0;
                bool setTimerLabelWidthFirstValue = false;
                bool setTimerLabelWidthSecondValue = false;
                float TimerLabelWidthFirstValue= 0;
                float TimerLabelWidthSecondValue= 0;
                bool setTimerValueHeightFirstValue = false;
                bool setTimerValueHeightSecondValue = false;
                float TimerValueHeightFirstValue= 0;
                float TimerValueHeightSecondValue= 0;
                bool setTimerValueWidthFirstValue = false;
                bool setTimerValueWidthSecondValue = false;
                float TimerValueWidthFirstValue= 0;
                float TimerValueWidthSecondValue= 0;
                bool setConditionDisplayBlueFirstValue = false;
                bool setConditionDisplayBlueSecondValue = false;
                int ConditionDisplayBlueFirstValue= 0;
                int ConditionDisplayBlueSecondValue= 0;
                bool setConditionDisplayGreenFirstValue = false;
                bool setConditionDisplayGreenSecondValue = false;
                int ConditionDisplayGreenFirstValue= 0;
                int ConditionDisplayGreenSecondValue= 0;
                bool setConditionDisplayRedFirstValue = false;
                bool setConditionDisplayRedSecondValue = false;
                int ConditionDisplayRedFirstValue= 0;
                int ConditionDisplayRedSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ConditionDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConditionDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameResult");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConditionDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Data.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setDataHeightFirstValue = true;
                        DataHeightFirstValue = 0f;
                        setDataWidthFirstValue = true;
                        DataWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Data.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Data.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Data.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Data.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DifficultyDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setDifficultyDisplayHeightFirstValue = true;
                        DifficultyDisplayHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DifficultyDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DifficultyDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setDifficultyDisplayWidthFirstValue = true;
                        DifficultyDisplayWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DifficultyDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setDifficultyValueHeightFirstValue = true;
                        DifficultyValueHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DifficultyValue.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DifficultyValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "DifficultyDisplay");
                        }
                        setDifficultyValueWidthFirstValue = true;
                        DifficultyValueWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DifficultyValue.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLastGameResultXFirstValue = true;
                        LastGameResultXFirstValue = 360f;
                        setLastGameResultYFirstValue = true;
                        LastGameResultYFirstValue = 121f;
                        if (interpolationValue < 1)
                        {
                            this.LivesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLivesContainerWidthFirstValue = true;
                        LivesContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LivesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesContainer.WrapsChildren = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setLivesDisplayHeightFirstValue = true;
                        LivesDisplayHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LivesDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setLivesDisplayWidthFirstValue = true;
                        LivesDisplayWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LivesDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLivesValueHeightFirstValue = true;
                        LivesValueHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LivesValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesValue.Text = "0";
                        }
                        setLivesValueWidthFirstValue = true;
                        LivesValueWidthFirstValue = 0f;
                        setLivesValueXFirstValue = true;
                        LivesValueXFirstValue = 0f;
                        setLivesValueYFirstValue = true;
                        LivesValueYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setScoreDisplayHeightFirstValue = true;
                        ScoreDisplayHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScoreDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setScoreDisplayWidthFirstValue = true;
                        ScoreDisplayWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setScoreLabelHeightFirstValue = true;
                        ScoreLabelHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScoreLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScoreDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScoreLabel.Text = "Score:";
                        }
                        setScoreLabelWidthFirstValue = true;
                        ScoreLabelWidthFirstValue = 0f;
                        setScoreValueHeightFirstValue = true;
                        ScoreValueHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScoreDisplay");
                        }
                        setScoreValueWidthFirstValue = true;
                        ScoreValueWidthFirstValue = 0f;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Lives:";
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        setTextInstance1HeightFirstValue = true;
                        TextInstance1HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "DifficultyDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "Difficulty:";
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
                            this.TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setTimerDisplayWidthFirstValue = true;
                        TimerDisplayWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTimerLabelHeightFirstValue = true;
                        TimerLabelHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimerLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimerLabel.Text = "Time Left:";
                        }
                        setTimerLabelWidthFirstValue = true;
                        TimerLabelWidthFirstValue = 0f;
                        setTimerValueHeightFirstValue = true;
                        TimerValueHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TimerValue.Text = "0";
                        }
                        setTimerValueWidthFirstValue = true;
                        TimerValueWidthFirstValue = 0f;
                        break;
                    case  VariableState.Win:
                        setConditionDisplayBlueFirstValue = true;
                        ConditionDisplayBlueFirstValue = 179;
                        setConditionDisplayGreenFirstValue = true;
                        ConditionDisplayGreenFirstValue = 222;
                        setConditionDisplayRedFirstValue = true;
                        ConditionDisplayRedFirstValue = 245;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ConditionDisplay.SourceFile", "medallist.png");
                        }
                        break;
                    case  VariableState.Lose:
                        setConditionDisplayBlueFirstValue = true;
                        ConditionDisplayBlueFirstValue = 0;
                        setConditionDisplayGreenFirstValue = true;
                        ConditionDisplayGreenFirstValue = 0;
                        setConditionDisplayRedFirstValue = true;
                        ConditionDisplayRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ConditionDisplay.SourceFile", "dead-head.png");
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ConditionDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConditionDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameResult");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConditionDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Data.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setDataHeightSecondValue = true;
                        DataHeightSecondValue = 0f;
                        setDataWidthSecondValue = true;
                        DataWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Data.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Data.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Data.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Data.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setDifficultyDisplayHeightSecondValue = true;
                        DifficultyDisplayHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setDifficultyDisplayWidthSecondValue = true;
                        DifficultyDisplayWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setDifficultyValueHeightSecondValue = true;
                        DifficultyValueHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyValue.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "DifficultyDisplay");
                        }
                        setDifficultyValueWidthSecondValue = true;
                        DifficultyValueWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DifficultyValue.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLastGameResultXSecondValue = true;
                        LastGameResultXSecondValue = 360f;
                        setLastGameResultYSecondValue = true;
                        LastGameResultYSecondValue = 121f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLivesContainerWidthSecondValue = true;
                        LivesContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesContainer.WrapsChildren = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setLivesDisplayHeightSecondValue = true;
                        LivesDisplayHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setLivesDisplayWidthSecondValue = true;
                        LivesDisplayWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLivesValueHeightSecondValue = true;
                        LivesValueHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesValue.Text = "0";
                        }
                        setLivesValueWidthSecondValue = true;
                        LivesValueWidthSecondValue = 0f;
                        setLivesValueXSecondValue = true;
                        LivesValueXSecondValue = 0f;
                        setLivesValueYSecondValue = true;
                        LivesValueYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setScoreDisplayHeightSecondValue = true;
                        ScoreDisplayHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScoreDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setScoreDisplayWidthSecondValue = true;
                        ScoreDisplayWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setScoreLabelHeightSecondValue = true;
                        ScoreLabelHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScoreLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScoreDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScoreLabel.Text = "Score:";
                        }
                        setScoreLabelWidthSecondValue = true;
                        ScoreLabelWidthSecondValue = 0f;
                        setScoreValueHeightSecondValue = true;
                        ScoreValueHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScoreDisplay");
                        }
                        setScoreValueWidthSecondValue = true;
                        ScoreValueWidthSecondValue = 0f;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Lives:";
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        setTextInstance1HeightSecondValue = true;
                        TextInstance1HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "DifficultyDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "Difficulty:";
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
                            this.TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setTimerDisplayWidthSecondValue = true;
                        TimerDisplayWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTimerLabelHeightSecondValue = true;
                        TimerLabelHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimerLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimerLabel.Text = "Time Left:";
                        }
                        setTimerLabelWidthSecondValue = true;
                        TimerLabelWidthSecondValue = 0f;
                        setTimerValueHeightSecondValue = true;
                        TimerValueHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TimerValue.Text = "0";
                        }
                        setTimerValueWidthSecondValue = true;
                        TimerValueWidthSecondValue = 0f;
                        break;
                    case  VariableState.Win:
                        setConditionDisplayBlueSecondValue = true;
                        ConditionDisplayBlueSecondValue = 179;
                        setConditionDisplayGreenSecondValue = true;
                        ConditionDisplayGreenSecondValue = 222;
                        setConditionDisplayRedSecondValue = true;
                        ConditionDisplayRedSecondValue = 245;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ConditionDisplay.SourceFile", "medallist.png");
                        }
                        break;
                    case  VariableState.Lose:
                        setConditionDisplayBlueSecondValue = true;
                        ConditionDisplayBlueSecondValue = 0;
                        setConditionDisplayGreenSecondValue = true;
                        ConditionDisplayGreenSecondValue = 0;
                        setConditionDisplayRedSecondValue = true;
                        ConditionDisplayRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ConditionDisplay.SourceFile", "dead-head.png");
                        }
                        break;
                }
                if (setDataHeightFirstValue && setDataHeightSecondValue)
                {
                    Data.Height = DataHeightFirstValue * (1 - interpolationValue) + DataHeightSecondValue * interpolationValue;
                }
                if (setDataWidthFirstValue && setDataWidthSecondValue)
                {
                    Data.Width = DataWidthFirstValue * (1 - interpolationValue) + DataWidthSecondValue * interpolationValue;
                }
                if (setDifficultyDisplayHeightFirstValue && setDifficultyDisplayHeightSecondValue)
                {
                    DifficultyDisplay.Height = DifficultyDisplayHeightFirstValue * (1 - interpolationValue) + DifficultyDisplayHeightSecondValue * interpolationValue;
                }
                if (setDifficultyDisplayWidthFirstValue && setDifficultyDisplayWidthSecondValue)
                {
                    DifficultyDisplay.Width = DifficultyDisplayWidthFirstValue * (1 - interpolationValue) + DifficultyDisplayWidthSecondValue * interpolationValue;
                }
                if (setDifficultyValueHeightFirstValue && setDifficultyValueHeightSecondValue)
                {
                    DifficultyValue.Height = DifficultyValueHeightFirstValue * (1 - interpolationValue) + DifficultyValueHeightSecondValue * interpolationValue;
                }
                if (setDifficultyValueWidthFirstValue && setDifficultyValueWidthSecondValue)
                {
                    DifficultyValue.Width = DifficultyValueWidthFirstValue * (1 - interpolationValue) + DifficultyValueWidthSecondValue * interpolationValue;
                }
                if (setLastGameResultXFirstValue && setLastGameResultXSecondValue)
                {
                    LastGameResult.X = LastGameResultXFirstValue * (1 - interpolationValue) + LastGameResultXSecondValue * interpolationValue;
                }
                if (setLastGameResultYFirstValue && setLastGameResultYSecondValue)
                {
                    LastGameResult.Y = LastGameResultYFirstValue * (1 - interpolationValue) + LastGameResultYSecondValue * interpolationValue;
                }
                if (setLivesContainerWidthFirstValue && setLivesContainerWidthSecondValue)
                {
                    LivesContainer.Width = LivesContainerWidthFirstValue * (1 - interpolationValue) + LivesContainerWidthSecondValue * interpolationValue;
                }
                if (setLivesDisplayHeightFirstValue && setLivesDisplayHeightSecondValue)
                {
                    LivesDisplay.Height = LivesDisplayHeightFirstValue * (1 - interpolationValue) + LivesDisplayHeightSecondValue * interpolationValue;
                }
                if (setLivesDisplayWidthFirstValue && setLivesDisplayWidthSecondValue)
                {
                    LivesDisplay.Width = LivesDisplayWidthFirstValue * (1 - interpolationValue) + LivesDisplayWidthSecondValue * interpolationValue;
                }
                if (setLivesValueHeightFirstValue && setLivesValueHeightSecondValue)
                {
                    LivesValue.Height = LivesValueHeightFirstValue * (1 - interpolationValue) + LivesValueHeightSecondValue * interpolationValue;
                }
                if (setLivesValueWidthFirstValue && setLivesValueWidthSecondValue)
                {
                    LivesValue.Width = LivesValueWidthFirstValue * (1 - interpolationValue) + LivesValueWidthSecondValue * interpolationValue;
                }
                if (setLivesValueXFirstValue && setLivesValueXSecondValue)
                {
                    LivesValue.X = LivesValueXFirstValue * (1 - interpolationValue) + LivesValueXSecondValue * interpolationValue;
                }
                if (setLivesValueYFirstValue && setLivesValueYSecondValue)
                {
                    LivesValue.Y = LivesValueYFirstValue * (1 - interpolationValue) + LivesValueYSecondValue * interpolationValue;
                }
                if (setScoreDisplayHeightFirstValue && setScoreDisplayHeightSecondValue)
                {
                    ScoreDisplay.Height = ScoreDisplayHeightFirstValue * (1 - interpolationValue) + ScoreDisplayHeightSecondValue * interpolationValue;
                }
                if (setScoreDisplayWidthFirstValue && setScoreDisplayWidthSecondValue)
                {
                    ScoreDisplay.Width = ScoreDisplayWidthFirstValue * (1 - interpolationValue) + ScoreDisplayWidthSecondValue * interpolationValue;
                }
                if (setScoreLabelHeightFirstValue && setScoreLabelHeightSecondValue)
                {
                    ScoreLabel.Height = ScoreLabelHeightFirstValue * (1 - interpolationValue) + ScoreLabelHeightSecondValue * interpolationValue;
                }
                if (setScoreLabelWidthFirstValue && setScoreLabelWidthSecondValue)
                {
                    ScoreLabel.Width = ScoreLabelWidthFirstValue * (1 - interpolationValue) + ScoreLabelWidthSecondValue * interpolationValue;
                }
                if (setScoreValueHeightFirstValue && setScoreValueHeightSecondValue)
                {
                    ScoreValue.Height = ScoreValueHeightFirstValue * (1 - interpolationValue) + ScoreValueHeightSecondValue * interpolationValue;
                }
                if (setScoreValueWidthFirstValue && setScoreValueWidthSecondValue)
                {
                    ScoreValue.Width = ScoreValueWidthFirstValue * (1 - interpolationValue) + ScoreValueWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
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
                if (setTimerLabelHeightFirstValue && setTimerLabelHeightSecondValue)
                {
                    TimerLabel.Height = TimerLabelHeightFirstValue * (1 - interpolationValue) + TimerLabelHeightSecondValue * interpolationValue;
                }
                if (setTimerLabelWidthFirstValue && setTimerLabelWidthSecondValue)
                {
                    TimerLabel.Width = TimerLabelWidthFirstValue * (1 - interpolationValue) + TimerLabelWidthSecondValue * interpolationValue;
                }
                if (setTimerValueHeightFirstValue && setTimerValueHeightSecondValue)
                {
                    TimerValue.Height = TimerValueHeightFirstValue * (1 - interpolationValue) + TimerValueHeightSecondValue * interpolationValue;
                }
                if (setTimerValueWidthFirstValue && setTimerValueWidthSecondValue)
                {
                    TimerValue.Width = TimerValueWidthFirstValue * (1 - interpolationValue) + TimerValueWidthSecondValue * interpolationValue;
                }
                if (setConditionDisplayBlueFirstValue && setConditionDisplayBlueSecondValue)
                {
                    ConditionDisplay.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ConditionDisplayBlueFirstValue* (1 - interpolationValue) + ConditionDisplayBlueSecondValue * interpolationValue);
                }
                if (setConditionDisplayGreenFirstValue && setConditionDisplayGreenSecondValue)
                {
                    ConditionDisplay.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ConditionDisplayGreenFirstValue* (1 - interpolationValue) + ConditionDisplayGreenSecondValue * interpolationValue);
                }
                if (setConditionDisplayRedFirstValue && setConditionDisplayRedSecondValue)
                {
                    ConditionDisplay.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ConditionDisplayRedFirstValue* (1 - interpolationValue) + ConditionDisplayRedSecondValue * interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Frbcon2019.GumRuntimes.ScoreboardGumRuntime.VariableState fromState,Frbcon2019.GumRuntimes.ScoreboardGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "LivesDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = LivesDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Height",
                            Type = "float",
                            Value = LivesDisplay.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Parent",
                            Type = "string",
                            Value = LivesDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Width",
                            Type = "float",
                            Value = LivesDisplay.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesDisplay.WidthUnits
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
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Height",
                            Type = "float",
                            Value = LivesValue.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Parent",
                            Type = "string",
                            Value = LivesValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Text",
                            Type = "string",
                            Value = LivesValue.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Width",
                            Type = "float",
                            Value = LivesValue.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.X",
                            Type = "float",
                            Value = LivesValue.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Y",
                            Type = "float",
                            Value = LivesValue.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ScoreDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Height",
                            Type = "float",
                            Value = ScoreDisplay.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScoreDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Parent",
                            Type = "string",
                            Value = ScoreDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Width",
                            Type = "float",
                            Value = ScoreDisplay.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScoreDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Height",
                            Type = "float",
                            Value = ScoreLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ScoreLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Parent",
                            Type = "string",
                            Value = ScoreLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Text",
                            Type = "string",
                            Value = ScoreLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Width",
                            Type = "float",
                            Value = ScoreLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreValue.Height",
                            Type = "float",
                            Value = ScoreValue.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreValue.Parent",
                            Type = "string",
                            Value = ScoreValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreValue.Width",
                            Type = "float",
                            Value = ScoreValue.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Data.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Height",
                            Type = "float",
                            Value = Data.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Width",
                            Type = "float",
                            Value = Data.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Data.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.X Units",
                            Type = "PositionUnitType",
                            Value = Data.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Data.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Y Units",
                            Type = "PositionUnitType",
                            Value = Data.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = DifficultyDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Height",
                            Type = "float",
                            Value = DifficultyDisplay.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Parent",
                            Type = "string",
                            Value = DifficultyDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Width",
                            Type = "float",
                            Value = DifficultyDisplay.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyDisplay.WidthUnits
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
                            Name = "TimerLabel.Height",
                            Type = "float",
                            Value = TimerLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TimerLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.Parent",
                            Type = "string",
                            Value = TimerLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.Text",
                            Type = "string",
                            Value = TimerLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.Width",
                            Type = "float",
                            Value = TimerLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Height",
                            Type = "float",
                            Value = TimerValue.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Parent",
                            Type = "string",
                            Value = TimerValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Text",
                            Type = "string",
                            Value = TimerValue.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Width",
                            Type = "float",
                            Value = TimerValue.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = LivesContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width",
                            Type = "float",
                            Value = LivesContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Wraps Children",
                            Type = "bool",
                            Value = LivesContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LastGameResult.X",
                            Type = "float",
                            Value = LastGameResult.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LastGameResult.Y",
                            Type = "float",
                            Value = LastGameResult.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = ConditionDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Parent",
                            Type = "string",
                            Value = ConditionDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = ConditionDisplay.WidthUnits
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
                            Name = "DifficultyValue.Height",
                            Type = "float",
                            Value = DifficultyValue.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Height Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyValue.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Parent",
                            Type = "string",
                            Value = DifficultyValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Width",
                            Type = "float",
                            Value = DifficultyValue.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Width Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyValue.WidthUnits
                        }
                        );
                        break;
                    case  VariableState.Win:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Blue",
                            Type = "int",
                            Value = ConditionDisplay.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Green",
                            Type = "int",
                            Value = ConditionDisplay.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Red",
                            Type = "int",
                            Value = ConditionDisplay.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.SourceFile",
                            Type = "string",
                            Value = ConditionDisplay.SourceFile
                        }
                        );
                        break;
                    case  VariableState.Lose:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Blue",
                            Type = "int",
                            Value = ConditionDisplay.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Green",
                            Type = "int",
                            Value = ConditionDisplay.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Red",
                            Type = "int",
                            Value = ConditionDisplay.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.SourceFile",
                            Type = "string",
                            Value = ConditionDisplay.SourceFile
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
                            Name = "LivesDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = LivesDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Height",
                            Type = "float",
                            Value = LivesDisplay.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Parent",
                            Type = "string",
                            Value = LivesDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Width",
                            Type = "float",
                            Value = LivesDisplay.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 0f
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
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Height",
                            Type = "float",
                            Value = LivesValue.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Parent",
                            Type = "string",
                            Value = LivesValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Text",
                            Type = "string",
                            Value = LivesValue.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Width",
                            Type = "float",
                            Value = LivesValue.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.X",
                            Type = "float",
                            Value = LivesValue.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesValue.Y",
                            Type = "float",
                            Value = LivesValue.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ScoreDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Height",
                            Type = "float",
                            Value = ScoreDisplay.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScoreDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Parent",
                            Type = "string",
                            Value = ScoreDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Width",
                            Type = "float",
                            Value = ScoreDisplay.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScoreDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Height",
                            Type = "float",
                            Value = ScoreLabel.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ScoreLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Parent",
                            Type = "string",
                            Value = ScoreLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Text",
                            Type = "string",
                            Value = ScoreLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreLabel.Width",
                            Type = "float",
                            Value = ScoreLabel.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreValue.Height",
                            Type = "float",
                            Value = ScoreValue.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreValue.Parent",
                            Type = "string",
                            Value = ScoreValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreValue.Width",
                            Type = "float",
                            Value = ScoreValue.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Data.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Height",
                            Type = "float",
                            Value = Data.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Width",
                            Type = "float",
                            Value = Data.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Data.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.X Units",
                            Type = "PositionUnitType",
                            Value = Data.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Data.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Data.Y Units",
                            Type = "PositionUnitType",
                            Value = Data.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Children Layout",
                            Type = "ChildrenLayout",
                            Value = DifficultyDisplay.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Height",
                            Type = "float",
                            Value = DifficultyDisplay.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Parent",
                            Type = "string",
                            Value = DifficultyDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Width",
                            Type = "float",
                            Value = DifficultyDisplay.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyDisplay.WidthUnits
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
                            Name = "TimerLabel.Height",
                            Type = "float",
                            Value = TimerLabel.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TimerLabel.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.Parent",
                            Type = "string",
                            Value = TimerLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.Text",
                            Type = "string",
                            Value = TimerLabel.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerLabel.Width",
                            Type = "float",
                            Value = TimerLabel.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Height",
                            Type = "float",
                            Value = TimerValue.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Parent",
                            Type = "string",
                            Value = TimerValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Text",
                            Type = "string",
                            Value = TimerValue.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TimerValue.Width",
                            Type = "float",
                            Value = TimerValue.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = LivesContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width",
                            Type = "float",
                            Value = LivesContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Wraps Children",
                            Type = "bool",
                            Value = LivesContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LastGameResult.X",
                            Type = "float",
                            Value = LastGameResult.X + 360f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LastGameResult.Y",
                            Type = "float",
                            Value = LastGameResult.Y + 121f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = ConditionDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Parent",
                            Type = "string",
                            Value = ConditionDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = ConditionDisplay.WidthUnits
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
                            Name = "DifficultyValue.Height",
                            Type = "float",
                            Value = DifficultyValue.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Height Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyValue.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Parent",
                            Type = "string",
                            Value = DifficultyValue.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Width",
                            Type = "float",
                            Value = DifficultyValue.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DifficultyValue.Width Units",
                            Type = "DimensionUnitType",
                            Value = DifficultyValue.WidthUnits
                        }
                        );
                        break;
                    case  VariableState.Win:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Blue",
                            Type = "int",
                            Value = ConditionDisplay.Blue + 179
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Green",
                            Type = "int",
                            Value = ConditionDisplay.Green + 222
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Red",
                            Type = "int",
                            Value = ConditionDisplay.Red + 245
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.SourceFile",
                            Type = "string",
                            Value = ConditionDisplay.SourceFile
                        }
                        );
                        break;
                    case  VariableState.Lose:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Blue",
                            Type = "int",
                            Value = ConditionDisplay.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Green",
                            Type = "int",
                            Value = ConditionDisplay.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.Red",
                            Type = "int",
                            Value = ConditionDisplay.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionDisplay.SourceFile",
                            Type = "string",
                            Value = ConditionDisplay.SourceFile
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
                        if (state.Name == "Win") this.mCurrentVariableState = VariableState.Win;
                        if (state.Name == "Lose") this.mCurrentVariableState = VariableState.Lose;
                    }
                }
                base.ApplyState(state);
            }
            public Frbcon2019.GumRuntimes.ContainerRuntime LivesDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime LivesValue { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime ScoreDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime ScoreLabel { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime ScoreValue { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime Data { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime DifficultyDisplay { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime TimerDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TimerLabel { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TimerValue { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime LivesContainer { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime LastGameResult { get; set; }
            public Frbcon2019.GumRuntimes.SpriteRuntime ConditionDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime DifficultyValue { get; set; }
            public string LivesValueText
            {
                get
                {
                    return LivesValue.Text;
                }
                set
                {
                    if (LivesValue.Text != value)
                    {
                        LivesValue.Text = value;
                        LivesValueTextChanged?.Invoke(this, null);
                    }
                }
            }
            public string ScoreValueText
            {
                get
                {
                    return ScoreValue.Text;
                }
                set
                {
                    if (ScoreValue.Text != value)
                    {
                        ScoreValue.Text = value;
                        ScoreValueTextChanged?.Invoke(this, null);
                    }
                }
            }
            public string TimerValueText
            {
                get
                {
                    return TimerValue.Text;
                }
                set
                {
                    if (TimerValue.Text != value)
                    {
                        TimerValue.Text = value;
                        TimerValueTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler LivesValueTextChanged;
            public event System.EventHandler ScoreValueTextChanged;
            public event System.EventHandler TimerValueTextChanged;
            public ScoreboardGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "ScoreboardGum");
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
                LivesDisplay = this.GetGraphicalUiElementByName("LivesDisplay") as Frbcon2019.GumRuntimes.ContainerRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as Frbcon2019.GumRuntimes.TextRuntime;
                LivesValue = this.GetGraphicalUiElementByName("LivesValue") as Frbcon2019.GumRuntimes.TextRuntime;
                ScoreDisplay = this.GetGraphicalUiElementByName("ScoreDisplay") as Frbcon2019.GumRuntimes.ContainerRuntime;
                ScoreLabel = this.GetGraphicalUiElementByName("ScoreLabel") as Frbcon2019.GumRuntimes.TextRuntime;
                ScoreValue = this.GetGraphicalUiElementByName("ScoreValue") as Frbcon2019.GumRuntimes.TextRuntime;
                Data = this.GetGraphicalUiElementByName("Data") as Frbcon2019.GumRuntimes.ContainerRuntime;
                DifficultyDisplay = this.GetGraphicalUiElementByName("DifficultyDisplay") as Frbcon2019.GumRuntimes.ContainerRuntime;
                TimerDisplay = this.GetGraphicalUiElementByName("TimerDisplay") as Frbcon2019.GumRuntimes.ContainerRuntime;
                TimerLabel = this.GetGraphicalUiElementByName("TimerLabel") as Frbcon2019.GumRuntimes.TextRuntime;
                TimerValue = this.GetGraphicalUiElementByName("TimerValue") as Frbcon2019.GumRuntimes.TextRuntime;
                LivesContainer = this.GetGraphicalUiElementByName("LivesContainer") as Frbcon2019.GumRuntimes.ContainerRuntime;
                LastGameResult = this.GetGraphicalUiElementByName("LastGameResult") as Frbcon2019.GumRuntimes.ContainerRuntime;
                ConditionDisplay = this.GetGraphicalUiElementByName("ConditionDisplay") as Frbcon2019.GumRuntimes.SpriteRuntime;
                TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as Frbcon2019.GumRuntimes.TextRuntime;
                DifficultyValue = this.GetGraphicalUiElementByName("DifficultyValue") as Frbcon2019.GumRuntimes.TextRuntime;
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
