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

        int slotWight;
        int slotHeight;
        int Collums;
        int Rows;
        int SelectedX, SelectedY;


        BaseItem[,] items;
        Backpack Test;
        Vector2 pos;
       

        public Inventory(Backpack Bpack, int Collums, int Rows, int SlotWidth, int SlothHeight,Vector2 Pos)
        {
            pos = Pos;
            slotWight = SlotWidth;
            slotHeight = SlothHeight;
            Test = Bpack;
            this.Collums = Collums;
            this.Rows = Rows;
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
                           
                        spriteBatch.Draw(AssetManager.GetInstance().texture["Slot"], new Rectangle((int)pos.X + (X * (slotWight + 2 )), (int)pos.Y + (Y * (slotHeight + 2)), slotWight, slotHeight), Color.SlateBlue);
                        if (items[X, Y] != null)
                        {
                            spriteBatch.DrawString(AssetManager.GetInstance().font["Arial_16"], (items[X, Y] as WeaponsItems).min_damge + "d" + (items[X, Y] as WeaponsItems).max_damge , new Vector2(0, 300), Color.Yellow,0,Vector2.Zero,1f,SpriteEffects.None,0f );
                        }
                    }
                    else
                    {
                        spriteBatch.Draw(AssetManager.GetInstance().texture["Slot"], new Rectangle((int)pos.X + (X * (slotWight + 2)), (int)pos.Y + (Y * (slotHeight + 2)), slotWight, slotHeight), Color.White);
                    }
                    if (items[X, Y] != null)
                    {
                        spriteBatch.Draw(items[X, Y].ItemTexture, new Rectangle((int)pos.X + 4+(X * (slotWight)), (int)pos.Y +4+ (Y * (slotHeight )), slotWight-8, slotHeight -8), items[X, Y].SourceRectangle, Color.White);
                        if(items[X,Y].Item_Count > 0)
                        {                     
                            spriteBatch.DrawString(AssetManager.GetInstance().font["Arial_16"], items[X, Y].Item_Count.ToString(), new Vector2(pos.X + (X* slotWight),pos.Y + (Y*slotWight)), Color.Yellow);
                        }
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
                    
                }
            }
        }
    }
}
