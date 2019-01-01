    namespace FlatRedBall.Gum
    {
        public  class GumIdbExtensions
        {
            public static void RegisterTypes () 
            {
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Circle", typeof(Frbcon2019.GumRuntimes.CircleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(Frbcon2019.GumRuntimes.ColoredRectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(Frbcon2019.GumRuntimes.ContainerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(Frbcon2019.GumRuntimes.NineSliceRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Polygon", typeof(Frbcon2019.GumRuntimes.PolygonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Rectangle", typeof(Frbcon2019.GumRuntimes.RectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(Frbcon2019.GumRuntimes.SpriteRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(Frbcon2019.GumRuntimes.TextRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Button", typeof(Frbcon2019.GumRuntimes.ButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LifeIcon", typeof(Frbcon2019.GumRuntimes.LifeIconRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("GameOverGum", typeof(Frbcon2019.GumRuntimes.GameOverGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MainMenuGum", typeof(Frbcon2019.GumRuntimes.MainMenuGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MiniGameBaseGum", typeof(Frbcon2019.GumRuntimes.MiniGameBaseGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ScoreboardGum", typeof(Frbcon2019.GumRuntimes.ScoreboardGumRuntime));
            }
        }
    }
