

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPGGame
{
    public class DebugScreen : BaseScreen
    {
        public  string Screens = "";
        public  string FocusScreen = "";
        private int fps;
        private int fpsCounter;
        private double fpsTimer;
        private string fpsText = "";

        //ring[] Strings;
        private Rectangle BGRect;
        SpriteFont Font;



        public DebugScreen()
        {
            

            Font = AssetManager.GetInstance().font["Arial_8"];
            Name = "Debug";
            ScreenState = State.Hidden;
            GrabFocus = false;
          

           
        }
        

        public override void HandleInput()
        {
            base.HandleInput();

            if (Input.KeyPressed(Keys.F1))
            {
                if (ScreenState == State.Active)
                {
                    ScreenState = State.Hidden;
                }
                else if (ScreenState == State.Hidden)
                {
                    ScreenState = State.Active;
                }
            }
        }

        public override void Update(GameTime gt)
        {
            base.Update(gt);
            if (Screens.Length > 0)
            {
                Screens = Screens.Substring(0, Screens.Length - 2);
            }

            int txtWidth = 0;
            int txtHeight = 0;

            if (Font.MeasureString(Screens).X > txtWidth)
            {
                txtWidth = (int)Font.MeasureString(Screens).X;
            }

            if (Font.MeasureString(FocusScreen).X > txtWidth)
            {
                txtWidth = (int)Font.MeasureString(FocusScreen).X;
            }

            txtHeight = (int)Font.MeasureString(fpsText).Y * 3;
            BGRect = new Rectangle(0, 0, txtWidth + 20, txtHeight + 20);


            if (gt.TotalGameTime.TotalMilliseconds > fpsTimer)
            {
                fps = fpsCounter;
                fpsTimer = gt.TotalGameTime.TotalMilliseconds + 1000;
                fpsCounter = 1;
                fpsText = "FPS: " + fps;

            }
            else
            {
                fpsCounter += 1;
            }
        }

        public override void Draw(SpriteBatch sp)
        {
            base.Draw(sp);
            
          

             string[] Strings = new string[3] { fpsText, Screens, FocusScreen };
            for (int i = 0; i < Strings.Length; i++)
            {
               
                sp.DrawString(Font, Strings[i], new Vector2(10, 10*(i*2)), Color.White);
            }

           
          
          
           
            
          
        }
    }
}