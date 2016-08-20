using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGAME
{
    public class BaseScreen 
    {   

        public bool IsFocused;


        public BaseScreen()
        {
            IsFocused = true;
        }
        public virtual void Draw(SpriteBatch spriteBatch) {}


        public virtual void Update(GameTime gameTime) {}

        public virtual void HandleInput()
        {
            
        }

        internal void Unload()
        {
            
        }
    }
}