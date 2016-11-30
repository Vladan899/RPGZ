using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class WeaponsItems : BaseItem
    {
      
        

       
     
        public WeaponsItems() 
        {
            Item_Name = "Null";
            ItemTexture = AssetManager.GetInstance().texture["baihu"];
            SourceRectangle = new Rectangle(0, 0, 64, 64);
            Max_StackSize = 1;


        }

        

       

        public void CreateKatana()
        {
            
           
           

        }
      



    }
}
