using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Inventory
    {

        int Wight;
        int Height;
        int Collums;
        int Rows;
        int SelectedX, SelectedY;
        public static int InventorySlots;

        BaseItem[,] items;
        Backpack Test;


        public Inventory(Backpack Bpack, int Collums, int Rows, int SlotWidth, int SlothHeight)
        {
            Wight = SlotWidth;
            Height = SlothHeight;
            Test = Bpack;
            this.Collums = Collums;
            this.Rows = Rows;
            items = new BaseItem[Collums, Rows];
            InventorySlots = Collums * Rows;
            LoadItems(Bpack);
        }
        public Inventory(Backpack Bpack, int Collums)
        {
            Test = Bpack;
            this.Collums = Collums;
            items = new BaseItem[Collums, Rows];
            LoadItems(Bpack);
        }



        public void Update(GameTime gameTime)
        {
            if (SelectedX > this.Collums-1)
            {
                SelectedX = Collums-1;
            }

            if (SelectedX < 0)
            {
                SelectedX = 0;
            }

            if(SelectedY > Rows-1)
            {
                SelectedY = Rows - 1;
            }
            if (SelectedY < 0)
            {
                SelectedY = 0;
            }


            if (Input.KeyPressed(Keys.A))
            {
                SelectedX -= 1;
            }
            if (Input.KeyPressed(Keys.D))
            {
                SelectedX += 1;
            }
            

            if (Input.KeyPressed(Keys.W))
            {
                SelectedY -= 1;
            }
            if (Input.KeyPressed(Keys.S))
            {
                SelectedY += 1;
            }
            Input.Update(gameTime);






        }
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int X = 0; X < Collums; X++)
            {
                for (int Y = 0; Y < Rows; Y++)
                {
                    if (SelectedX == X && SelectedY == Y)
                    {
                        spriteBatch.Draw(AssetManager.GetInstance().texture["Slot"], new Rectangle(0 + (X * (Wight + 2 )), 0 + (Y * (Height + 2)), Wight, Height), Color.SlateBlue);
                    }
                    else
                    {
                        spriteBatch.Draw(AssetManager.GetInstance().texture["Slot"], new Rectangle(0 + (X * (Wight + 2)), 0 + (Y * (Height + 2)), Wight, Height), Color.White);
                    }
                    if (items[X, Y] != null)
                    {
                        spriteBatch.Draw(items[X, Y].ItemTexture, new Rectangle(0 + (X * (Wight)), 0 + (Y * (Wight + 2 )), Wight, Height), items[X, Y].SourceRectangle, Color.White);
                    }


                }
            }
        }

        
        public void LoadItems(Backpack BPack)
        {
            int itemIndex = 0;
            for (int x = 0; x < Collums; x++)
            {
                for (int y = 0; y < Rows; y++)
                {   
                    if(itemIndex < BPack.Items.Count)
                    {
                       items[x,y] = BPack.Items[itemIndex];
                        itemIndex++;
                    }
                    break;
                }
            }
        }
    }
}
