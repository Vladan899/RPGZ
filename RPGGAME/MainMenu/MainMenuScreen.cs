using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPGGame
{
    class MainMenuScreen : BaseScreen
    {
        MenuEntry Entries;
        string[] MenuText = new string[4] { "New Game", "Load Game", "Options","Exit To Desktop" };
        bool[] Enabled = new bool[4] { true, true, true,true };
        //string texts = "";
        SpriteFont font = AssetManager.GetInstance().font["Verdana_16"]; 
        public MainMenuScreen(): base()
        {
            Name = "Main Menu";
            ScreenState = State.Active;
            Entries = new MenuEntry("Verdana_16", MenuText, Enabled);


            
        }

        public override void Update(GameTime gameTime)
        {

            Entries.Update();
            if (Input.KeyPressed(Keys.Enter))
            {

                switch (Entries.menuSelect)
                {
                    case 0:
                        ScreenManager.UnloadScreens("Main Menu");
                        ScreenManager.UnloadScreens("Title Screen");
                        ScreenManager.AddScreen(new SelectScreen());
                        
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;



                }

                

                base.Update(gameTime);
            }
        }

        public override void Draw(SpriteBatch sp)
        {
            Entries.Draw(sp,new Vector2((Game1.graphics.GraphicsDevice.Viewport.Width / 2)- font.Texture.Width /2 ,200));
            //sp.DrawString(font, texts, new Vector2(100, 0), Color.Aqua);
            base.Draw(sp);
        }

        public override void Unload()
        {
            base.Unload();
        }

        public override void HandleInput()
        {
            
            base.HandleInput();
        }
    }
}