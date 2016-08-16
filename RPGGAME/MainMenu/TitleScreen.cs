using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RPGGame
{
    public class TitleScreen : BaseScreen
    {


        
        //Texture2D Title = AssetManager.GetInstance().texture["Title"];

        public TitleScreen()
        {
            Name = "Title Screen";
            ScreenState = State.Active;
           
        }

        public override void Update(GameTime gameTime )
        {
            
           
        }

        public override void Draw(SpriteBatch sp)
        {
            base.Draw(sp);
          
           

        }

        public override void Unload()
        {
            base.Unload();
        }
    }
}