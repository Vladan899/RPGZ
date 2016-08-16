using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPGHAME
{
    public class BaseScreen 
    {
        public bool IsFocused;
        public bool Focused;
        public bool CanInteract;
        public string Name;

        public State ScreenState { get; internal set; }

        public BaseScreen()
        {
            IsFocused = true;
        }
        public virtual void Draw(SpriteBatch spriteBatch) { }


        public virtual void Update(GameTime gameTime) {}

        public virtual void HandleInput()
        {
            
        }

        internal void Unload()
        {
            throw new NotImplementedException();
        }
    }
}