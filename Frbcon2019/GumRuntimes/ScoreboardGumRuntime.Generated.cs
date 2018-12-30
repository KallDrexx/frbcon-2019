    using System.Linq;
    namespace Frbcon2019.GumRuntimes
    {
        public partial class ScoreboardGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            TimerDisplay.Height = 0f;
                            TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                            TimerDisplay.Width = 0f;
                            TimerLabel.Height = 0f;
                            TimerLabel.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TimerLabel.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                            TimerLabel.Text = "Time Left:";
                            TimerLabel.Width = 0f;
                            TimerValue.Height = 0f;
                            TimerValue.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TimerDisplay");
                            TimerValue.Text = "0";
                            TimerValue.Width = 0f;
                            LastGameCondition.X = 340f;
                            LastGameCondition.Y = 89f;
                            WinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            WinText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameCondition");
                            WinText.Text = "Good Job!";
                            FailText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            FailText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameCondition");
                            FailText.Text = "Better Luck Next Time!\n";
                            FailText.Width = 200f;
                            FailText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
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
                bool setFailTextWidthFirstValue = false;
                bool setFailTextWidthSecondValue = false;
                float FailTextWidthFirstValue= 0;
                float FailTextWidthSecondValue= 0;
                bool setLastGameConditionXFirstValue = false;
                bool setLastGameConditionXSecondValue = false;
                float LastGameConditionXFirstValue= 0;
                float LastGameConditionXSecondValue= 0;
                bool setLastGameConditionYFirstValue = false;
                bool setLastGameConditionYSecondValue = false;
                float LastGameConditionYFirstValue= 0;
                float LastGameConditionYSecondValue= 0;
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
                switch(firstState)
                {
                    case  VariableState.Default:
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
                            this.FailText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FailText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameCondition");
                        }
                        if (interpolationValue < 1)
                        {
                            this.FailText.Text = "Better Luck Next Time!\n";
                        }
                        setFailTextWidthFirstValue = true;
                        FailTextWidthFirstValue = 200f;
                        if (interpolationValue < 1)
                        {
                            this.FailText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLastGameConditionXFirstValue = true;
                        LastGameConditionXFirstValue = 340f;
                        setLastGameConditionYFirstValue = true;
                        LastGameConditionYFirstValue = 89f;
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
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTimerDisplayHeightFirstValue = true;
                        TimerDisplayHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setTimerDisplayWidthFirstValue = true;
                        TimerDisplayWidthFirstValue = 0f;
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
                        if (interpolationValue < 1)
                        {
                            this.WinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WinText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameCondition");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WinText.Text = "Good Job!";
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
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
                            this.FailText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FailText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameCondition");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FailText.Text = "Better Luck Next Time!\n";
                        }
                        setFailTextWidthSecondValue = true;
                        FailTextWidthSecondValue = 200f;
                        if (interpolationValue >= 1)
                        {
                            this.FailText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLastGameConditionXSecondValue = true;
                        LastGameConditionXSecondValue = 340f;
                        setLastGameConditionYSecondValue = true;
                        LastGameConditionYSecondValue = 89f;
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
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTimerDisplayHeightSecondValue = true;
                        TimerDisplayHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TimerDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "Data");
                        }
                        setTimerDisplayWidthSecondValue = true;
                        TimerDisplayWidthSecondValue = 0f;
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
                        if (interpolationValue >= 1)
                        {
                            this.WinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WinText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LastGameCondition");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WinText.Text = "Good Job!";
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
                if (setFailTextWidthFirstValue && setFailTextWidthSecondValue)
                {
                    FailText.Width = FailTextWidthFirstValue * (1 - interpolationValue) + FailTextWidthSecondValue * interpolationValue;
                }
                if (setLastGameConditionXFirstValue && setLastGameConditionXSecondValue)
                {
                    LastGameCondition.X = LastGameConditionXFirstValue * (1 - interpolationValue) + LastGameConditionXSecondValue * interpolationValue;
                }
                if (setLastGameConditionYFirstValue && setLastGameConditionYSecondValue)
                {
                    LastGameCondition.Y = LastGameConditionYFirstValue * (1 - interpolationValue) + LastGameConditionYSecondValue * interpolationValue;
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
                            Name = "LastGameCondition.X",
                            Type = "float",
                            Value = LastGameCondition.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LastGameCondition.Y",
                            Type = "float",
                            Value = LastGameCondition.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WinText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = WinText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WinText.Parent",
                            Type = "string",
                            Value = WinText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WinText.Text",
                            Type = "string",
                            Value = WinText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = FailText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Parent",
                            Type = "string",
                            Value = FailText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Text",
                            Type = "string",
                            Value = FailText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Width",
                            Type = "float",
                            Value = FailText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Width Units",
                            Type = "DimensionUnitType",
                            Value = FailText.WidthUnits
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
                            Name = "LastGameCondition.X",
                            Type = "float",
                            Value = LastGameCondition.X + 340f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LastGameCondition.Y",
                            Type = "float",
                            Value = LastGameCondition.Y + 89f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WinText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = WinText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WinText.Parent",
                            Type = "string",
                            Value = WinText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WinText.Text",
                            Type = "string",
                            Value = WinText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = FailText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Parent",
                            Type = "string",
                            Value = FailText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Text",
                            Type = "string",
                            Value = FailText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Width",
                            Type = "float",
                            Value = FailText.Width + 200f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FailText.Width Units",
                            Type = "DimensionUnitType",
                            Value = FailText.WidthUnits
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
            public Frbcon2019.GumRuntimes.ContainerRuntime LivesDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TextInstance { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime LivesValue { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime ScoreDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime ScoreLabel { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime ScoreValue { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime Data { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime TimerDisplay { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TimerLabel { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime TimerValue { get; set; }
            public Frbcon2019.GumRuntimes.ContainerRuntime LastGameCondition { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime WinText { get; set; }
            public Frbcon2019.GumRuntimes.TextRuntime FailText { get; set; }
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
                TimerDisplay = this.GetGraphicalUiElementByName("TimerDisplay") as Frbcon2019.GumRuntimes.ContainerRuntime;
                TimerLabel = this.GetGraphicalUiElementByName("TimerLabel") as Frbcon2019.GumRuntimes.TextRuntime;
                TimerValue = this.GetGraphicalUiElementByName("TimerValue") as Frbcon2019.GumRuntimes.TextRuntime;
                LastGameCondition = this.GetGraphicalUiElementByName("LastGameCondition") as Frbcon2019.GumRuntimes.ContainerRuntime;
                WinText = this.GetGraphicalUiElementByName("WinText") as Frbcon2019.GumRuntimes.TextRuntime;
                FailText = this.GetGraphicalUiElementByName("FailText") as Frbcon2019.GumRuntimes.TextRuntime;
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
