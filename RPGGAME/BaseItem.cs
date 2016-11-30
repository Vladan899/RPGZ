using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class BaseItem
    {
        public enum ItemClass
        {
            Weapon,
            Armor,
            Quest,
            Usable,
            Gems,
            Null,

        }

      
        public Texture2D ItemTexture { get; set; }
        public string Item_Name { get; set; }
        public Rectangle SourceRectangle { get; set; }
        public bool is_Stackable { get; set; } 
        public int Item_Count { get; set; }
        public int Max_StackSize { get; set; }
        public int Value { get; set; }

        public BaseItem()
        {
            
        }


    }
}
