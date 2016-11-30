using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    public class Input
    {

        static KeyboardState CurrentKeyState;

        static KeyboardState LastKeyState;
        static MouseState CurrentMkeyState;

        static MouseState LastMKeyState;
        public static void Update(GameTime gameTime)
        {
            LastKeyState = CurrentKeyState;
            CurrentKeyState = Keyboard.GetState();
            LastMKeyState = CurrentMkeyState;
            CurrentMkeyState = Mouse.GetState();


        }

        public static bool KeyDown(Keys key)
        {
            return CurrentKeyState.IsKeyDown(key);
        }
        public static bool MouseRightKeyDown()
        {
            return CurrentMkeyState.RightButton == ButtonState.Pressed;
        }
        public static bool MouseLeftKeyDown()
        {
            return CurrentMkeyState.LeftButton == ButtonState.Pressed;
        }

        public static bool KeyPressed(Keys key)
        {
            if (CurrentKeyState.IsKeyDown(key) & LastKeyState.IsKeyUp(key))
            {
                return true;
            }
            return false;
        }
        public static bool KeyMouseLeftPressed()
        {
            if (CurrentMkeyState.LeftButton == ButtonState.Pressed  & LastMKeyState.LeftButton == ButtonState.Released)
            {
                return true;
            }
            return false;
        }

        public static bool KeyMouseRightPressed()
        {
            if (CurrentMkeyState.RightButton == ButtonState.Pressed & LastMKeyState.RightButton == ButtonState.Released)
            {
                return true;
            }
            return false;
        }
    }
}
