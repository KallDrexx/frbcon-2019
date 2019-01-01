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
    public partial class MiniGameBase : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb MiniGameBaseGum;
        
        private Frbcon2019.GumRuntimes.TextRuntime TimerValue;
        private Frbcon2019.GumRuntimes.TextRuntime InstructionsTimeLeftText;
        private Frbcon2019.GumRuntimes.TextRuntime InstructionsDisplayedText;
        private Frbcon2019.GumRuntimes.TextRuntime GameTimeLeft;
        private Frbcon2019.GumRuntimes.ButtonRuntime ButtonInstance;
        private Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime MiniGameBaseGumRuntime;
        private Frbcon2019.GumRuntimes.ColoredRectangleRuntime ContentBlocker;
        string mInstructionsText = "Splash Text Showing Instructions";
        public virtual string InstructionsText
        {
            set
            {
                mInstructionsText = value;
            }
            get
            {
                return mInstructionsText;
            }
        }
        public int InstructionsDurationInSeconds = 3;
        public int GameTimeDurationInSeconds = 5;
        public MiniGameBase () 
        	: base ("MiniGameBase")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            TimerValue = MiniGameBaseGum.GetGraphicalUiElementByName("TimerValue") as Frbcon2019.GumRuntimes.TextRuntime;
            InstructionsTimeLeftText = MiniGameBaseGum.GetGraphicalUiElementByName("InstructionsTimeLeftText") as Frbcon2019.GumRuntimes.TextRuntime;
            InstructionsDisplayedText = MiniGameBaseGum.GetGraphicalUiElementByName("Instructions") as Frbcon2019.GumRuntimes.TextRuntime;
            GameTimeLeft = MiniGameBaseGum.GetGraphicalUiElementByName("GameTimeLeft") as Frbcon2019.GumRuntimes.TextRuntime;
            ButtonInstance = MiniGameBaseGum.GetGraphicalUiElementByName("ButtonInstance") as Frbcon2019.GumRuntimes.ButtonRuntime;
            MiniGameBaseGumRuntime = MiniGameBaseGum.GetGraphicalUiElementByName("this") as Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime;
            ContentBlocker = MiniGameBaseGum.GetGraphicalUiElementByName("ContentBlocker") as Frbcon2019.GumRuntimes.ColoredRectangleRuntime;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            MiniGameBaseGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += MiniGameBaseGum.HandleResolutionChanged;
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
            FlatRedBall.SpriteManager.RemoveDrawableBatch(MiniGameBaseGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= MiniGameBaseGum.HandleResolutionChanged;
            MiniGameBaseGum = null;
            
            if (TimerValue != null)
            {
                TimerValue.RemoveFromManagers();
            }
            if (InstructionsTimeLeftText != null)
            {
                InstructionsTimeLeftText.RemoveFromManagers();
            }
            if (InstructionsDisplayedText != null)
            {
                InstructionsDisplayedText.RemoveFromManagers();
            }
            if (GameTimeLeft != null)
            {
                GameTimeLeft.RemoveFromManagers();
            }
            if (ButtonInstance != null)
            {
                ButtonInstance.RemoveFromManagers();
            }
            if (MiniGameBaseGumRuntime != null)
            {
                MiniGameBaseGumRuntime.RemoveFromManagers();
            }
            if (ContentBlocker != null)
            {
                ContentBlocker.RemoveFromManagers();
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
            if (TimerValue != null)
            {
                TimerValue.RemoveFromManagers();
            }
            if (InstructionsTimeLeftText != null)
            {
                InstructionsTimeLeftText.RemoveFromManagers();
            }
            if (InstructionsDisplayedText != null)
            {
                InstructionsDisplayedText.RemoveFromManagers();
            }
            if (GameTimeLeft != null)
            {
                GameTimeLeft.RemoveFromManagers();
            }
            if (ButtonInstance != null)
            {
                ButtonInstance.RemoveFromManagers();
            }
            if (MiniGameBaseGumRuntime != null)
            {
                MiniGameBaseGumRuntime.RemoveFromManagers();
            }
            if (ContentBlocker != null)
            {
                ContentBlocker.RemoveFromManagers();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            InstructionsText = "Splash Text Showing Instructions";
            InstructionsDurationInSeconds = 3;
            GameTimeDurationInSeconds = 5;
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
            Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;  MiniGameBaseGum = new FlatRedBall.Gum.GumIdb();  MiniGameBaseGum.LoadFromFile("content/gumproject/screens/minigamebasegum.gusx");  MiniGameBaseGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false; MiniGameBaseGum.Element.UpdateLayout(); MiniGameBaseGum.Element.UpdateLayout();
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
                case  "MiniGameBaseGum":
                    return MiniGameBaseGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "MiniGameBaseGum":
                    return MiniGameBaseGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "MiniGameBaseGum":
                    return MiniGameBaseGum;
            }
            return null;
        }
    }
}
