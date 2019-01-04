#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace Frbcon2019.Screens
{
    public partial class Scoreboard : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb ScoreboardGum;
        
        private Frbcon2019.GumRuntimes.TextRuntime LivesValue;
        private Frbcon2019.GumRuntimes.TextRuntime ScoreValue;
        private Frbcon2019.GumRuntimes.TextRuntime TimerValue;
        private Frbcon2019.GumRuntimes.ContainerRuntime LivesContainer;
        private Frbcon2019.GumRuntimes.ScoreboardGumRuntime ScoreboardGumRuntime;
        private Frbcon2019.GumRuntimes.TextRuntime DifficultyValue;
        public int SecondsUntilNextGameStarts = 3;
        public int NumberOfGamesBeforeDifficultyIncrease = 3;
        public string ForcedMinigameType = "";
        public Scoreboard () 
        	: base ("Scoreboard")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            LivesValue = ScoreboardGum.GetGraphicalUiElementByName("LivesValue") as Frbcon2019.GumRuntimes.TextRuntime;
            ScoreValue = ScoreboardGum.GetGraphicalUiElementByName("ScoreValue") as Frbcon2019.GumRuntimes.TextRuntime;
            TimerValue = ScoreboardGum.GetGraphicalUiElementByName("TimerValue") as Frbcon2019.GumRuntimes.TextRuntime;
            LivesContainer = ScoreboardGum.GetGraphicalUiElementByName("LivesContainer") as Frbcon2019.GumRuntimes.ContainerRuntime;
            ScoreboardGumRuntime = ScoreboardGum.GetGraphicalUiElementByName("this") as Frbcon2019.GumRuntimes.ScoreboardGumRuntime;
            DifficultyValue = ScoreboardGum.GetGraphicalUiElementByName("DifficultyValue") as Frbcon2019.GumRuntimes.TextRuntime;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            ScoreboardGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += ScoreboardGum.HandleResolutionChanged;
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            FlatRedBall.SpriteManager.RemoveDrawableBatch(ScoreboardGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= ScoreboardGum.HandleResolutionChanged;
            ScoreboardGum = null;
            
            if (LivesValue != null)
            {
                LivesValue.RemoveFromManagers();
            }
            if (ScoreValue != null)
            {
                ScoreValue.RemoveFromManagers();
            }
            if (TimerValue != null)
            {
                TimerValue.RemoveFromManagers();
            }
            if (LivesContainer != null)
            {
                LivesContainer.RemoveFromManagers();
            }
            if (ScoreboardGumRuntime != null)
            {
                ScoreboardGumRuntime.RemoveFromManagers();
            }
            if (DifficultyValue != null)
            {
                DifficultyValue.RemoveFromManagers();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            if (LivesValue != null)
            {
                LivesValue.RemoveFromManagers();
            }
            if (ScoreValue != null)
            {
                ScoreValue.RemoveFromManagers();
            }
            if (TimerValue != null)
            {
                TimerValue.RemoveFromManagers();
            }
            if (LivesContainer != null)
            {
                LivesContainer.RemoveFromManagers();
            }
            if (ScoreboardGumRuntime != null)
            {
                ScoreboardGumRuntime.RemoveFromManagers();
            }
            if (DifficultyValue != null)
            {
                DifficultyValue.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            SecondsUntilNextGameStarts = 3;
            NumberOfGamesBeforeDifficultyIncrease = 3;
            ForcedMinigameType = "";
        }
        public virtual void ConvertToManuallyUpdated () 
        {
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.CoreUIs;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  ScoreboardGum = new FlatRedBall.Gum.GumIdb();  ScoreboardGum.LoadFromFile("content/gumproject/screens/scoreboardgum.gusx");  ScoreboardGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; ScoreboardGum.Element.UpdateLayout(); ScoreboardGum.Element.UpdateLayout();
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "ScoreboardGum":
                    return ScoreboardGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "ScoreboardGum":
                    return ScoreboardGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "ScoreboardGum":
                    return ScoreboardGum;
            }
            return null;
        }
    }
}
