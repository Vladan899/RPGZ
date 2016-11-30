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

        public int min_damge;
        public int max_damge;
        public int rarity;
        

        public enum WeaponType
        {
            Short_Sword,
            Long_Sword,
            Dagger,
            Bow,
            Axe,
            Polearm
        }
        


        
        public WeaponsItems() 
        {
            ItemType = ItemClass.Weapon;
            is_Stackable = false;
            //BoundingBox = new Rectangle(0, 0, ItemTexture.Width, ItemTexture.Height);

        }


    }
}
