using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGHAME
{
    public class Input
    {
        static KeyboardState CurrentKeyState;

        static KeyboardState LastKeyState;
        public static void Update(GameTime gameTime)
        {
            LastKeyState = CurrentKeyState;
            CurrentKeyState = Keyboard.GetState();
        }

        public static bool KeyDown(Keys key)
        {
            return CurrentKeyState.IsKeyDown(key);
        }

        public static bool KeyPressed(Keys key)
        {
            if (CurrentKeyState.IsKeyDown(key) & LastKeyState.IsKeyUp(key))
            {
                return true;
            }
            return false;
        }
    }
}
