using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace RPGGame
{
    public enum State
    {
        Active,
        ShutDown,
        Hidden
    }
    public  class ScreenManager
    {
        private static List<BaseScreen> Screens = new List<BaseScreen>();
        private static List<BaseScreen> NewScreens = new List<BaseScreen>();
        private DebugScreen Debug;
        SpriteFont font;

        public ScreenManager()       
        {
            Debug = new DebugScreen();
            
            font = AssetManager.GetInstance().font["Arial_8"];
            Debug = new DebugScreen();
            AddScreen(Debug);
        }
        public void Update(GameTime gameTime)
        {
            Debug.Screens = "Screens: ";
            //GENERATE LIST OF DEAD SCREENS FOR REMOVAL
            List<BaseScreen> RemoveScreens = new List<BaseScreen>();
            foreach (var screen in Screens)
            {
                if (screen.ScreenState == State.ShutDown)
                {
                    RemoveScreens.Add(screen);
                }
                else
                {
                    Debug.Screens += screen.Name + ", ";
                    screen.Focused = false;
                }
            }

            //REMOVE DEAD SCREENS
            foreach (BaseScreen screen in RemoveScreens)
            {
                Screens.Remove(screen);
            }
            //ADD NEW SCREENS TO MANAGER LIST
            foreach (BaseScreen screen in NewScreens)
            {
                Screens.Add(screen);
            }
            NewScreens.Clear();


            //RESET DEBUG SCREEN TO TOP OF THE LIST
            Screens.Remove(Debug);
            Screens.Add(Debug);

            //CHECK SCREEN FOCUS
            if (Screens.Count > 0)
            {
                for (int i = Screens.Count - 1; i >= 0; i += -1)
                {
                    if (Screens[i].GrabFocus)
                    {
                        Screens[i].Focused = true;
                        Debug.FocusScreen = "Focused Screen: " + Screens[i].Name;
                        //break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }
            else
            {
                Debug.FocusScreen = "Focused Screen: ";
            }

            //HANDLE INPUT FOR FOCUSED SCREEN
            foreach (var screen in Screens)
            {
                
                // MAKING SURE THE GAME WINDOW HAS FOCUS
                if (Game1.WindowFocused)
                {
                    screen.HandleInput();
                }
                screen.Update(gameTime);
            }

        }



        public void Draw(SpriteBatch sp)
        {
            foreach (var screen in Screens)
            {
                if(screen.ScreenState == State.Active)
                {
                    screen.Draw(sp);
                }
            }
           // sp.DrawString(font, "Yes", new Vector2(0, 100), Color.White);
        }
        public static void AddScreen(BaseScreen screen)
        {
            NewScreens.Add(screen);
        }
        public static void UnloadScreens(string Screen)
        {
            foreach (var foundScreen in Screens)
            {
                if(foundScreen.Name == Screen)
                {
                    foundScreen.Unload();
                    break;
                }
                
            }
        }
    }
}
