#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using Frbcon2019.Entities.ShooGame;
namespace Frbcon2019.Screens
{
    public partial class ShooGame : MiniGameBase
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb ShooGameGum;
        
        private Frbcon2019.Entities.ShooGame.Broom BroomInstance;
        public System.Double SecondsForBroomSweep = 0.25;
        public ShooGame () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            BroomInstance = new Frbcon2019.Entities.ShooGame.Broom(ContentManagerName, false);
            BroomInstance.Name = "BroomInstance";
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            ShooGameGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += ShooGameGum.HandleResolutionChanged;
            BroomInstance.AddToManagers(mLayer);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                BroomInstance.Activity();
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
            FlatRedBall.SpriteManager.RemoveDrawableBatch(ShooGameGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= ShooGameGum.HandleResolutionChanged;
            ShooGameGum = null;
            
            if (BroomInstance != null)
            {
                BroomInstance.Destroy();
                BroomInstance.Detach();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            BroomInstance.RemoveFromManagers();
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
                BroomInstance.AssignCustomVariables(true);
            }
            InstructionsText = "Shoo the mice away!";
            SecondsForBroomSweep = 0.25;
            GameTimeDurationInSeconds = 5;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            BroomInstance.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            Frbcon2019.Screens.MiniGameBase.LoadStaticContent(contentManagerName);
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
            if(ShooGameGum == null)
{
Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;
ShooGameGum = new FlatRedBall.Gum.GumIdb(); 
ShooGameGum.LoadFromFile("content/gumproject/screens/shoogamegum.gusx");  ShooGameGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false;
ShooGameGum.Element.UpdateLayout();
ShooGameGum.Element.UpdateLayout();
};
            Frbcon2019.Entities.ShooGame.Broom.LoadStaticContent(contentManagerName);
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
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "ShooGameGum":
                    return ShooGameGum;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "ShooGameGum":
                    return ShooGameGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "ShooGameGum":
                    return ShooGameGum;
            }
            return null;
        }
    }
}
