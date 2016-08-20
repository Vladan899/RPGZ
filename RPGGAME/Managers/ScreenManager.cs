using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    public class ScreenManager
    {
        private static List<BaseScreen> Screens = new List<BaseScreen>();

        public ScreenManager()
        {
            AddScreen(new MainMenu());
        }

        public void Update(GameTime GameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        private static void AddScreen(BaseScreen screen)
        {
            Screens.Add(screen);
        }

        private static void RemoveScreen(BaseScreen screen)
        {
            Screens.Remove(screen);
        }

        public void ChangeScreen(BaseScreen NewScreen,BaseScreen OldScreen)
        {
            AddScreen(NewScreen);
            RemoveScreen(OldScreen);
        }
    }
}
