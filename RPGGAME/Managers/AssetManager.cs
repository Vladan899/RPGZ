using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    class AssetManager
    {

        static ContentManager CM;
        static AssetManager instance;
        public static AssetManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AssetManager();

            }
            return instance;
        }

        public Dictionary<string, Texture2D> texture;
        public Dictionary<string, SpriteFont> font;

        private AssetManager()
        {
            texture = new Dictionary<string, Texture2D>();
            font = new Dictionary<string, SpriteFont>();
        }



        public void LoadStuff(ContentManager content)
        {
            CM = content;

            AddFont("Arial_16");
            //AddFont("Verdana_16");
            //AddFont("Metamorphous_16");
            //AddTexture("DirtTile");




        }
        public void AddTexture(string file, string name = "")
        {
            Texture2D newTexure = CM.Load<Texture2D>(file);
            if (name == "")
            {
                texture.Add(file, newTexure);
            }
            else
            {
                texture.Add(name, newTexure);
            }
        }
        public void AddFont(string file, string name = "")
        {
            SpriteFont newfont = CM.Load<SpriteFont>(file);
            if (name == "")
            {
                font.Add(file, newfont);
            }
            else
            {
                font.Add(name, newfont);
            }
        }
    }
}
