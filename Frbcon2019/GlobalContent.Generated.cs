#if ANDROID || IOS || DESKTOP_GL
// Android doesn't allow background loading. iOS doesn't allow background rendering (which is used by converting textures to use premult alpha)
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using System.Collections.Generic;
using System.Threading;
using FlatRedBall;
using FlatRedBall.Math.Geometry;
using FlatRedBall.ManagedSpriteGroups;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Utilities;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using FlatRedBall.Localization;

namespace Frbcon2019
{
    public static partial class GlobalContent
    {
        
        public static FlatRedBall.Gum.GumIdb CoreUIs { get; set; }
        static Microsoft.Xna.Framework.Graphics.Texture2D mbabe_ease_spritesheet;
        public static Microsoft.Xna.Framework.Graphics.Texture2D babe_ease_spritesheet
        {
            get
            {
                if (mbabe_ease_spritesheet == null)
                {
                    mbabe_ease_spritesheet = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/globalcontent/babycatcher/babe_ease_spritesheet.png", ContentManagerName);
                }
                return mbabe_ease_spritesheet;
            }
        }
        public static Microsoft.Xna.Framework.Media.Song prologue { get; set; }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "CoreUIs":
                    return CoreUIs;
                case  "babe_ease_spritesheet":
                    return babe_ease_spritesheet;
                case  "prologue":
                    return prologue;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "CoreUIs":
                    return CoreUIs;
                case  "babe_ease_spritesheet":
                    return babe_ease_spritesheet;
                case  "prologue":
                    return prologue;
            }
            return null;
        }
        public static bool IsInitialized { get; private set; }
        public static bool ShouldStopLoading { get; set; }
        const string ContentManagerName = "Global";
        public static void Initialize () 
        {
            
            FlatRedBall.Gum.GumIdb.StaticInitialize("content/gumproject/coreuis.gumx"); FlatRedBall.Gum.GumIdbExtensions.RegisterTypes();  FlatRedBall.Gui.GuiManager.BringsClickedWindowsToFront = false;FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += (not, used) => { FlatRedBall.Gum.GumIdb.UpdateDisplayToMainFrbCamera(); };Gum.Wireframe.GraphicalUiElement.ShowLineRectangles = false;
            prologue = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Media.Song>(@"content/globalcontent/babycatcher/prologue", ContentManagerName);
            			IsInitialized = true;
            // Added by GumPlugin becasue of the Show Mouse checkbox on the .gumx:
            FlatRedBall.FlatRedBallServices.Game.IsMouseVisible = true;
            #if DEBUG && WINDOWS
            InitializeFileWatch();
            #endif
        }
        public static void Reload (object whatToReload) 
        {
        }
        #if DEBUG && WINDOWS
        static System.IO.FileSystemWatcher watcher;
        private static void InitializeFileWatch () 
        {
            string globalContent = FlatRedBall.IO.FileManager.RelativeDirectory + "content/globalcontent/";
            if (System.IO.Directory.Exists(globalContent))
            {
                watcher = new System.IO.FileSystemWatcher();
                watcher.Path = globalContent;
                watcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
                watcher.Filter = "*.*";
                watcher.Changed += HandleFileChanged;
                watcher.EnableRaisingEvents = true;
            }
        }
        private static void HandleFileChanged (object sender, System.IO.FileSystemEventArgs e) 
        {
            try
            {
                System.Threading.Thread.Sleep(500);
                var fullFileName = e.FullPath;
                var relativeFileName = FlatRedBall.IO.FileManager.MakeRelative(FlatRedBall.IO.FileManager.Standardize(fullFileName));
                if (relativeFileName == "content/gumproject/coreuis.gumx")
                {
                    Reload(CoreUIs);
                }
                if (relativeFileName == "content/globalcontent/babycatcher/babe_ease_spritesheet.png")
                {
                    Reload(babe_ease_spritesheet);
                }
                if (relativeFileName == "content/globalcontent/babycatcher/prologue.mp3")
                {
                    Reload(prologue);
                }
            }
            catch{}
        }
        #endif
        
        
    }
}
