
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RPGGame
{
    public abstract class BaseScreen
    {


        public float Position;
        public float Alpha;
        public bool Focused = false;
        public bool GrabFocus = true;
        public string Name;
        public State ScreenState = State.Active;


        public virtual void HandleInput()
        {

        }
        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch sp)
        {

        }
        public virtual void Unload()
        {
            ScreenState = State.ShutDown;
        }

        
    }
}