#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using Frbcon2019.Entities.SpaceInvaders;
using FlatRedBall.Math;
namespace Frbcon2019.Screens
{
    public partial class SpaceInvaders : MiniGameBase
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.Gum.GumIdb SpaceInvadersGum;
        
        private Frbcon2019.Entities.SpaceInvaders.PlayerShip PlayerShipInstance;
        private FlatRedBall.Math.PositionedObjectList<Frbcon2019.Entities.SpaceInvaders.Bullet> BulletList;
        private FlatRedBall.Math.PositionedObjectList<Frbcon2019.Entities.SpaceInvaders.Alien> AlienList;
        private Frbcon2019.Entities.SpaceInvaders.GuardRail RightGuardRail;
        private Frbcon2019.Entities.SpaceInvaders.GuardRail LeftGuardRail;
        public int PlayerYPosition = -200;
        public int AlienStartY = 250;
        public int BulletSpeed = 900;
        public int AlienMovementSpeed = 200;
        public SpaceInvaders () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            PlayerShipInstance = new Frbcon2019.Entities.SpaceInvaders.PlayerShip(ContentManagerName, false);
            PlayerShipInstance.Name = "PlayerShipInstance";
            BulletList = new FlatRedBall.Math.PositionedObjectList<Frbcon2019.Entities.SpaceInvaders.Bullet>();
            BulletList.Name = "BulletList";
            AlienList = new FlatRedBall.Math.PositionedObjectList<Frbcon2019.Entities.SpaceInvaders.Alien>();
            AlienList.Name = "AlienList";
            RightGuardRail = new Frbcon2019.Entities.SpaceInvaders.GuardRail(ContentManagerName, false);
            RightGuardRail.Name = "RightGuardRail";
            LeftGuardRail = new Frbcon2019.Entities.SpaceInvaders.GuardRail(ContentManagerName, false);
            LeftGuardRail.Name = "LeftGuardRail";
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            SpaceInvadersGum.InstanceInitialize(); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += SpaceInvadersGum.HandleResolutionChanged;
            Factories.BulletFactory.Initialize(ContentManagerName);
            Factories.BulletFactory.AddList(BulletList);
            PlayerShipInstance.AddToManagers(mLayer);
            RightGuardRail.AddToManagers(mLayer);
            LeftGuardRail.AddToManagers(mLayer);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                PlayerShipInstance.Activity();
                for (int i = BulletList.Count - 1; i > -1; i--)
                {
                    if (i < BulletList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        BulletList[i].Activity();
                    }
                }
                for (int i = AlienList.Count - 1; i > -1; i--)
                {
                    if (i < AlienList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        AlienList[i].Activity();
                    }
                }
                RightGuardRail.Activity();
                LeftGuardRail.Activity();
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
            Factories.BulletFactory.Destroy();
            FlatRedBall.SpriteManager.RemoveDrawableBatch(SpaceInvadersGum); FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= SpaceInvadersGum.HandleResolutionChanged;
            SpaceInvadersGum = null;
            
            BulletList.MakeOneWay();
            AlienList.MakeOneWay();
            if (PlayerShipInstance != null)
            {
                PlayerShipInstance.Destroy();
                PlayerShipInstance.Detach();
            }
            for (int i = BulletList.Count - 1; i > -1; i--)
            {
                BulletList[i].Destroy();
            }
            for (int i = AlienList.Count - 1; i > -1; i--)
            {
                AlienList[i].Destroy();
            }
            if (RightGuardRail != null)
            {
                RightGuardRail.Destroy();
                RightGuardRail.Detach();
            }
            if (LeftGuardRail != null)
            {
                LeftGuardRail.Destroy();
                LeftGuardRail.Detach();
            }
            BulletList.MakeTwoWay();
            AlienList.MakeTwoWay();
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
            PlayerShipInstance.RemoveFromManagers();
            for (int i = BulletList.Count - 1; i > -1; i--)
            {
                BulletList[i].Destroy();
            }
            for (int i = AlienList.Count - 1; i > -1; i--)
            {
                AlienList[i].Destroy();
            }
            RightGuardRail.RemoveFromManagers();
            LeftGuardRail.RemoveFromManagers();
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
                PlayerShipInstance.AssignCustomVariables(true);
                RightGuardRail.AssignCustomVariables(true);
                LeftGuardRail.AssignCustomVariables(true);
            }
            InstructionsText = "Repel All Invaders!";
            PlayerYPosition = -200;
            AlienStartY = 250;
            BulletSpeed = 900;
            GameTimeDurationInSeconds = 5;
            AlienMovementSpeed = 200;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            PlayerShipInstance.ConvertToManuallyUpdated();
            for (int i = 0; i < BulletList.Count; i++)
            {
                BulletList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < AlienList.Count; i++)
            {
                AlienList[i].ConvertToManuallyUpdated();
            }
            RightGuardRail.ConvertToManuallyUpdated();
            LeftGuardRail.ConvertToManuallyUpdated();
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
            if(SpaceInvadersGum == null)
{
Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = true;
SpaceInvadersGum = new FlatRedBall.Gum.GumIdb(); 
SpaceInvadersGum.LoadFromFile("content/gumproject/screens/spaceinvadersgum.gusx");  SpaceInvadersGum.AssignReferences();Gum.Wireframe.GraphicalUiElement.IsAllLayoutSuspended = false;
SpaceInvadersGum.Element.UpdateLayout();
SpaceInvadersGum.Element.UpdateLayout();
};
            Frbcon2019.Entities.SpaceInvaders.PlayerShip.LoadStaticContent(contentManagerName);
            Frbcon2019.Entities.SpaceInvaders.GuardRail.LoadStaticContent(contentManagerName);
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
                case  "SpaceInvadersGum":
                    return SpaceInvadersGum;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "SpaceInvadersGum":
                    return SpaceInvadersGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "SpaceInvadersGum":
                    return SpaceInvadersGum;
            }
            return null;
        }
    }
}
