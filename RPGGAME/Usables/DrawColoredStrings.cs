using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class DrawColoredStrings
    {
        
        Color[] StringColor;
        string[] Strings;
        Vector2 Position;
        SpriteFont Font;

        Vector2 offset = Vector2.Zero;

        /// <summary>
        /// Draws string on index x using same index X on vector2
        /// </summary>
        /// <param name="Font"></param>
        /// <param name="strings"></param>
        /// <param name="colors"></param>
        /// <param name="position"></param>
        public DrawColoredStrings(string font,string[] strings, Color[]  sec, Vector2 position)
        {
           
            Font = AssetManager.GetInstance().font[font];
            StringColor = sec;
            Position = position;
            Strings = strings;
     
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 offset = Vector2.Zero;
            for (int i = 0; i < Strings.Length; i++)
            {
              
                spriteBatch.DrawString(Font, Strings[i], Position + offset, StringColor[i]);
                offset.X += Font.MeasureString(Strings[i]).X;
            }
            
        }
        public void DrawList(SpriteBatch spriteBatch)
        {
            Vector2 offset = Vector2.Zero;
            for (int i = 0; i < Strings.Length; i++)
            {
                    spriteBatch.DrawString(Font, Strings[i] , Position + offset, StringColor[i]);
                    offset.Y +=20;
                
            }

        }

    }
}
