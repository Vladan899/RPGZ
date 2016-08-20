using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    class MenuEntry
    {

        string[] EntriyText;
        bool[] enabled;
        bool[] visible;

        public List<MenuEntry> Entries = new List<MenuEntry>();
        SpriteFont font;
        int MenuSelect;
        int width;
        int height;
        public int menuSelect
        {
            get { return MenuSelect; }
            set
            {
                MenuSelect = value;

                if (MenuSelect < 0)

                    MenuSelect = 0;

                if (MenuSelect >= Entries.Count)

                    MenuSelect = Entries.Count - 1;
            }

        }
        public MenuEntry(string File, string[] text, bool[] Enabled, bool[] Visible)
        {

            font = AssetManager.GetInstance().font[File];
            EntriyText = text;
            this.enabled = Enabled;
            this.visible = Visible;
            MesureString(File);
        }



        private void MesureString(string text)
        {
            height = 0;
            width = 0;
            Vector2 size = font.MeasureString(text);
            if (size.X > width)
            {
                width = (int)size.X;
            }
            height += font.LineSpacing + 8;

        }



        public void HandleInput()
        {
            // MENU UP
            if (Input.KeyPressed(Keys.Up) | Input.KeyPressed(Keys.W))
            {
                MenuSelect -= 1;
                if (MenuSelect < 0)
                    MenuSelect = EntriyText.Length - 1;
                //SKIP DISABLED ENTRIES
                while (!(enabled[MenuSelect] == true))
                {
                    MenuSelect -= 1;
                    if (MenuSelect < 0)
                        MenuSelect = EntriyText.Length - 1;
                }
            }

            // MENU UP
            if (Input.KeyPressed(Keys.Down) | Input.KeyPressed(Keys.S))
            {
                MenuSelect += 1;
                if (MenuSelect > EntriyText.Length - 1)
                    MenuSelect = 0;
                //SKIP DISABLED ENTRIES
                while (!(enabled[MenuSelect] == true))
                {
                    MenuSelect += 1;
                    if (MenuSelect > EntriyText.Length - 1)
                        MenuSelect = 0;
                }
            }
        }


        public void Update()
        {

            HandleInput();
        }
        public void Draw(SpriteBatch sp, Vector2 pos)
        {

            for (int i = 0; i < EntriyText.Length; i++)
            {
                float MenuY = pos.Y += 20;
                if (i == MenuSelect)
                {
                    sp.DrawString(font, EntriyText[i], pos, Color.Red);
                }
                else if (enabled[i] == true && visible[i] == true)
                {
                    sp.DrawString(font, EntriyText[i], pos, Color.White);
                }
                else if (enabled[i] == false && visible[i] == false)
                {
                    sp.DrawString(font, EntriyText[i], pos, Color.Gray);
                }
                else
                {
                    sp.DrawString(font, EntriyText[i], pos, Color.Transparent);
                }
                pos.Y += 20;

            }
        }
    }
}
