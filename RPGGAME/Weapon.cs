using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Weapon : BaseItems, IWeaponStats
    {
        Random random = new Random();

        
        
        public Weapon()
        {
            itemType = 0;
            isStackable = false;
            stackCount = 1;
        }

        private string WeaponName
        {
            get { return itemName; }
            set
            {
                if(ItemSubType == 0 & rarity == 0)
                {
                    itemName = "Short Sword"; 
                }
                else if (ItemSubType == 0 & rarity >= 1)
                {
                    itemName = Prefix_Name + "Short Sword" + Sufix_Name; ;
                }
            }
        }

        private int maximum_damage;
        public int Maximum_Damage
        {
            get
            {
                return maximum_damage;
            }

            set
            {
                
            }
        }
        private int minimal_Damage;
        public int Minimal_Damage
        {
            get
            {
                return minimal_Damage;
            }

            set
            {
               
            }
        }

        private byte prefix_index;
        public byte Prefix_Index
        {
            get
            {
                return prefix_index;
            }

            set
            {
                
            }
        }
        private string prefix_Name;
        public string Prefix_Name
        {
            get
            {
                return prefix_Name;
            }

            set
            {
               
            }
        }
        private byte rarity;
        public byte Rarity
        {
            get
            {
                return rarity;
            }

            set
            {
               
            }
        }
        public IAttributes stat;
        public IAttributes Stats
        {
            get
            {
                return stat;
            }

            set
            {
               
            }
        }
        byte sufix_Index;
        public byte Sufix_Index
        {
            get
            {
                return sufix_Index;
            }

            set
            {
                
            }
        }
        string sufix_Name;
        public string Sufix_Name
        {
            get
            {
                return sufix_Name;
            }

            set
            {
                
            }
        }

        public float Prefix_effect
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float Sufix_effect
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
       
   
}
