#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math.Geometry;
namespace Frbcon2019.Entities.SpaceInvaders
{
    public partial class Bullet : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Math.Geometry.ICollidable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Graphics.Texture2D shells;
        
        private FlatRedBall.Sprite SpriteInstance;
        static float SpriteInstanceXReset;
        static float SpriteInstanceYReset;
        static float SpriteInstanceZReset;
        static float SpriteInstanceXVelocityReset;
        static float SpriteInstanceYVelocityReset;
        static float SpriteInstanceZVelocityReset;
        static float SpriteInstanceRotationXReset;
        static float SpriteInstanceRotationYReset;
        static float SpriteInstanceRotationZReset;
        static float SpriteInstanceRotationXVelocityReset;
        static float SpriteInstanceRotationYVelocityReset;
        static float SpriteInstanceRotationZVelocityReset;
        static float SpriteInstanceAlphaReset;
        static float SpriteInstanceAlphaRateReset;
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle mCollisionBox;
        public FlatRedBall.Math.Geometry.AxisAlignedRectangle CollisionBox
        {
            get
            {
                return mCollisionBox;
            }
            private set
            {
                mCollisionBox = value;
            }
        }
        static float CollisionBoxXReset;
        static float CollisionBoxYReset;
        static float CollisionBoxZReset;
        static float CollisionBoxXVelocityReset;
        static float CollisionBoxYVelocityReset;
        static float CollisionBoxZVelocityReset;
        static float CollisionBoxRotationXReset;
        static float CollisionBoxRotationYReset;
        static float CollisionBoxRotationZReset;
        static float CollisionBoxRotationXVelocityReset;
        static float CollisionBoxRotationYVelocityReset;
        static float CollisionBoxRotationZVelocityReset;
        public int Index { get; set; }
        public bool Used { get; set; }
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public Bullet () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public Bullet (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public Bullet (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            SpriteInstance = new FlatRedBall.Sprite();
            SpriteInstance.Name = "SpriteInstance";
            mCollisionBox = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            mCollisionBox.Name = "mCollisionBox";
            
            PostInitialize();
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceXReset = SpriteInstance.X;
            }
            else
            {
                SpriteInstanceXReset = SpriteInstance.RelativeX;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceYReset = SpriteInstance.Y;
            }
            else
            {
                SpriteInstanceYReset = SpriteInstance.RelativeY;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceZReset = SpriteInstance.Z;
            }
            else
            {
                SpriteInstanceZReset = SpriteInstance.RelativeZ;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceXVelocityReset = SpriteInstance.XVelocity;
            }
            else
            {
                SpriteInstanceXVelocityReset = SpriteInstance.RelativeXVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceYVelocityReset = SpriteInstance.YVelocity;
            }
            else
            {
                SpriteInstanceYVelocityReset = SpriteInstance.RelativeYVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceZVelocityReset = SpriteInstance.ZVelocity;
            }
            else
            {
                SpriteInstanceZVelocityReset = SpriteInstance.RelativeZVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationXReset = SpriteInstance.RotationX;
            }
            else
            {
                SpriteInstanceRotationXReset = SpriteInstance.RelativeRotationX;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationYReset = SpriteInstance.RotationY;
            }
            else
            {
                SpriteInstanceRotationYReset = SpriteInstance.RelativeRotationY;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationZReset = SpriteInstance.RotationZ;
            }
            else
            {
                SpriteInstanceRotationZReset = SpriteInstance.RelativeRotationZ;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationXVelocityReset = SpriteInstance.RotationXVelocity;
            }
            else
            {
                SpriteInstanceRotationXVelocityReset = SpriteInstance.RelativeRotationXVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationYVelocityReset = SpriteInstance.RotationYVelocity;
            }
            else
            {
                SpriteInstanceRotationYVelocityReset = SpriteInstance.RelativeRotationYVelocity;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstanceRotationZVelocityReset = SpriteInstance.RotationZVelocity;
            }
            else
            {
                SpriteInstanceRotationZVelocityReset = SpriteInstance.RelativeRotationZVelocity;
            }
            SpriteInstanceAlphaReset = SpriteInstance.Alpha;
            SpriteInstanceAlphaRateReset = SpriteInstance.AlphaRate;
            if (CollisionBox.Parent == null)
            {
                CollisionBoxXReset = CollisionBox.X;
            }
            else
            {
                CollisionBoxXReset = CollisionBox.RelativeX;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxYReset = CollisionBox.Y;
            }
            else
            {
                CollisionBoxYReset = CollisionBox.RelativeY;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxZReset = CollisionBox.Z;
            }
            else
            {
                CollisionBoxZReset = CollisionBox.RelativeZ;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxXVelocityReset = CollisionBox.XVelocity;
            }
            else
            {
                CollisionBoxXVelocityReset = CollisionBox.RelativeXVelocity;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxYVelocityReset = CollisionBox.YVelocity;
            }
            else
            {
                CollisionBoxYVelocityReset = CollisionBox.RelativeYVelocity;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxZVelocityReset = CollisionBox.ZVelocity;
            }
            else
            {
                CollisionBoxZVelocityReset = CollisionBox.RelativeZVelocity;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxRotationXReset = CollisionBox.RotationX;
            }
            else
            {
                CollisionBoxRotationXReset = CollisionBox.RelativeRotationX;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxRotationYReset = CollisionBox.RotationY;
            }
            else
            {
                CollisionBoxRotationYReset = CollisionBox.RelativeRotationY;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxRotationZReset = CollisionBox.RotationZ;
            }
            else
            {
                CollisionBoxRotationZReset = CollisionBox.RelativeRotationZ;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxRotationXVelocityReset = CollisionBox.RotationXVelocity;
            }
            else
            {
                CollisionBoxRotationXVelocityReset = CollisionBox.RelativeRotationXVelocity;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxRotationYVelocityReset = CollisionBox.RotationYVelocity;
            }
            else
            {
                CollisionBoxRotationYVelocityReset = CollisionBox.RelativeRotationYVelocity;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBoxRotationZVelocityReset = CollisionBox.RotationZVelocity;
            }
            else
            {
                CollisionBoxRotationZVelocityReset = CollisionBox.RelativeRotationZVelocity;
            }
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCollisionBox, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            PostInitialize();
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mCollisionBox, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            
            CustomActivity();
        }
        public virtual void Destroy () 
        {
            if (Used)
            {
                Factories.BulletFactory.MakeUnused(this, false);
            }
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (CollisionBox != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CollisionBox);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            SpriteInstance.Texture = shells;
            SpriteInstance.LeftTexturePixel = 664f;
            SpriteInstance.RightTexturePixel = 718f;
            SpriteInstance.TopTexturePixel = 591f;
            SpriteInstance.BottomTexturePixel = 615f;
            SpriteInstance.TextureScale = 1f;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationZ = 4.71f;
            }
            else
            {
                SpriteInstance.RelativeRotationZ = 4.71f;
            }
            if (mCollisionBox.Parent == null)
            {
                mCollisionBox.CopyAbsoluteToRelative();
                mCollisionBox.AttachTo(this, false);
            }
            CollisionBox.Width = 24f;
            CollisionBox.Height = 52f;
            CollisionBox.Visible = false;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            mGeneratedCollision.AxisAlignedRectangles.AddOneWay(mCollisionBox);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (CollisionBox != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(CollisionBox);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            SpriteInstance.Texture = shells;
            SpriteInstance.LeftTexturePixel = 664f;
            SpriteInstance.RightTexturePixel = 718f;
            SpriteInstance.TopTexturePixel = 591f;
            SpriteInstance.BottomTexturePixel = 615f;
            SpriteInstance.TextureScale = 1f;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationZ = 4.71f;
            }
            else
            {
                SpriteInstance.RelativeRotationZ = 4.71f;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.X = SpriteInstanceXReset;
            }
            else
            {
                SpriteInstance.RelativeX = SpriteInstanceXReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.Y = SpriteInstanceYReset;
            }
            else
            {
                SpriteInstance.RelativeY = SpriteInstanceYReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.Z = SpriteInstanceZReset;
            }
            else
            {
                SpriteInstance.RelativeZ = SpriteInstanceZReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.XVelocity = SpriteInstanceXVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeXVelocity = SpriteInstanceXVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.YVelocity = SpriteInstanceYVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeYVelocity = SpriteInstanceYVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.ZVelocity = SpriteInstanceZVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeZVelocity = SpriteInstanceZVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationX = SpriteInstanceRotationXReset;
            }
            else
            {
                SpriteInstance.RelativeRotationX = SpriteInstanceRotationXReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationY = SpriteInstanceRotationYReset;
            }
            else
            {
                SpriteInstance.RelativeRotationY = SpriteInstanceRotationYReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationZ = SpriteInstanceRotationZReset;
            }
            else
            {
                SpriteInstance.RelativeRotationZ = SpriteInstanceRotationZReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationXVelocity = SpriteInstanceRotationXVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeRotationXVelocity = SpriteInstanceRotationXVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationYVelocity = SpriteInstanceRotationYVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeRotationYVelocity = SpriteInstanceRotationYVelocityReset;
            }
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.RotationZVelocity = SpriteInstanceRotationZVelocityReset;
            }
            else
            {
                SpriteInstance.RelativeRotationZVelocity = SpriteInstanceRotationZVelocityReset;
            }
            SpriteInstance.Alpha = SpriteInstanceAlphaReset;
            SpriteInstance.AlphaRate = SpriteInstanceAlphaRateReset;
            CollisionBox.Width = 24f;
            CollisionBox.Height = 52f;
            CollisionBox.Visible = false;
            if (CollisionBox.Parent == null)
            {
                CollisionBox.X = CollisionBoxXReset;
            }
            else
            {
                CollisionBox.RelativeX = CollisionBoxXReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.Y = CollisionBoxYReset;
            }
            else
            {
                CollisionBox.RelativeY = CollisionBoxYReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.Z = CollisionBoxZReset;
            }
            else
            {
                CollisionBox.RelativeZ = CollisionBoxZReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.XVelocity = CollisionBoxXVelocityReset;
            }
            else
            {
                CollisionBox.RelativeXVelocity = CollisionBoxXVelocityReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.YVelocity = CollisionBoxYVelocityReset;
            }
            else
            {
                CollisionBox.RelativeYVelocity = CollisionBoxYVelocityReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.ZVelocity = CollisionBoxZVelocityReset;
            }
            else
            {
                CollisionBox.RelativeZVelocity = CollisionBoxZVelocityReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.RotationX = CollisionBoxRotationXReset;
            }
            else
            {
                CollisionBox.RelativeRotationX = CollisionBoxRotationXReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.RotationY = CollisionBoxRotationYReset;
            }
            else
            {
                CollisionBox.RelativeRotationY = CollisionBoxRotationYReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.RotationZ = CollisionBoxRotationZReset;
            }
            else
            {
                CollisionBox.RelativeRotationZ = CollisionBoxRotationZReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.RotationXVelocity = CollisionBoxRotationXVelocityReset;
            }
            else
            {
                CollisionBox.RelativeRotationXVelocity = CollisionBoxRotationXVelocityReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.RotationYVelocity = CollisionBoxRotationYVelocityReset;
            }
            else
            {
                CollisionBox.RelativeRotationYVelocity = CollisionBoxRotationYVelocityReset;
            }
            if (CollisionBox.Parent == null)
            {
                CollisionBox.RotationZVelocity = CollisionBoxRotationZVelocityReset;
            }
            else
            {
                CollisionBox.RelativeRotationZVelocity = CollisionBoxRotationZVelocityReset;
            }
            if (Parent == null)
            {
                Z = -1f;
            }
            else if (Parent is FlatRedBall.Camera)
            {
                RelativeZ = -1f - 40.0f;
            }
            else
            {
                RelativeZ = -1f;
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            ContentManagerName = contentManagerName;
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
            bool registerUnload = false;
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BulletStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/spaceinvaders/bullet/shells.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                shells = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/spaceinvaders/bullet/shells.png", ContentManagerName);
            }
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BulletStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (shells != null)
                {
                    shells= null;
                }
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "shells":
                    return shells;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "shells":
                    return shells;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "shells":
                    return shells;
            }
            return null;
        }
        protected bool mIsPaused;
        public override void Pause (FlatRedBall.Instructions.InstructionList instructions) 
        {
            base.Pause(instructions);
            mIsPaused = true;
        }
        public virtual void SetToIgnorePausing () 
        {
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(CollisionBox);
        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SpriteInstance);
            }
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(CollisionBox);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(CollisionBox, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
    }
}
