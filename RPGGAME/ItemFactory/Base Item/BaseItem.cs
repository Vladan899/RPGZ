using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    public class BaseItem : IItemTypeTier
    {
        public string Name { get; internal set; }
        public string Lore { get; internal set; }
        public int Value { get; internal set; }

        /// <summary>
        ///0 = Damaged,
        ///1 = Common,
        ///2 = Superior,
        ///3 = Magical,
        ///4 = Rare,
        ///5 = Legendary,
        ///6 = Set  
        /// </summary>
        public int Rarirty { get; set; }

      

     


        public bool IsStackable { get; internal set; }

        public uint StackSize { get; internal set; }
        public Texture2D testure { get; internal set; }

        /// <summary>
        /// 0 = Armor
        /// 1 = Weapons
        /// 3 = Acssessory Ring
        /// 4 = Acssessory Amulet
        /// 5 = Legendary Potions
        /// 6 = Gems
        /// 7 = Legendary Gems
        /// 8 = Crafting
        /// 9 = Keys
        /// </summary>
        public byte ItemType { get; internal set; }
        private byte Tier;
        public byte tier
        {
            get
            {
                return Tier;
            }

            set
            {
                Tier = (byte)Value;
            }
        }
        private byte Type;
        public byte type
        {
            get
            {
                return Type;
            }

            set
            {
                Type = (byte)Value;
            }
        }
        private string TeirName;
        public string tierName
        {
            get
            {
                return TeirName;
            }

            set
            {
                if(ItemType == 0)
                {
                    if (Tier == 0)
                    {
                        TeirName = "Letheral";
                    }
                    else if (Tier == 1)
                    {
                        TeirName = "Hide";
                    }
                    else if (Tier == 2)
                    {
                        TeirName = "Hide";
                    }
                    else if (Tier == 3)
                    {
                        TeirName = "Chainmail";
                    }
                    else if (Tier == 4)
                    {
                        TeirName = "Scale";
                    }
                    else if (Tier == 5)
                    {
                        TeirName = "Plate";
                    }
                    else TeirName = "Invalid Armor Teir";
                }
               
                else if (ItemType == 1)
                {
                    if (Tier == 0)
                    {
                        TeirName = "Woooden";
                    }
                    else if (Tier == 1)
                    {
                        TeirName = "Stone";
                    }
                    else if (Tier == 2)
                    {
                        TeirName = "Iron";
                    }
                    else if (Tier == 3)
                    {
                        TeirName = "Steel";
                    }
                    else if (Tier == 4)
                    {
                        TeirName = "Damascus";
                    }
                    else if (Tier == 5)
                    {
                        TeirName = "Diamond";
                    }
                    else if (Tier == 5)
                    {
                        TeirName = "Mitril";
                    }
                    else if (Tier == 6)
                    {
                        TeirName = "Adamantium";
                    }
                    else TeirName = "Invalid Weapon Teir";
                }
                else if (ItemType == 2)
                {
                    if (Tier == 0)
                    {
                        TeirName = "Copper";
                    }
                    else if (Tier == 1)
                    {
                        TeirName = "Iron";
                    }
                    else if (Tier == 2)
                    {
                        TeirName = "Bronze";
                    }
                    else if (Tier == 3)
                    {
                        TeirName = "Golden";
                    }
                    else if (Tier == 4)
                    {
                        TeirName = "Diamond";
                    }
                    else TeirName = "Invalid Ring Teir";
                }

            }
        }
        private string TypeName;
        public string typeName
        {
            get
            {
                return TypeName;
            }

            set
            {
                if (ItemType == 0)
                {
                    if (Type == 0)
                    {
                        TypeName = "Helmet";
                    }
                    else if (Type == 1)
                    {
                        TypeName = "Chest";
                    }
                    else if (Type == 2)
                    {
                        TypeName = "Shoulders";
                    }
                    else if (Type == 3)
                    {
                        TypeName = "Gloves";
                    }
                    else if (Type == 4)
                    {
                        TypeName = "Boots";
                    }
                    else if (Type == 5)
                    {
                        TypeName = "Belt";
                    }
                    else if (Type == 6)
                    {
                        TypeName = "Shield";
                    }
                    else TypeName = "Invalid Type";
                }
                else if (ItemType == 1)
                {
                    if (Type == 0)
                    {
                        TypeName = "Sword";
                    }
                    else if (Type == 1)
                    {
                        TypeName = "Bow";
                    }
                    else if (Type == 2)
                    {
                        TypeName = "Staff";
                    }
                    else if (Type == 3)
                    {
                        TypeName = "2H-Sword";
                    }
                    else if (Type == 4)
                    {
                        TypeName = "Mace";
                    }
                    else if (Type == 5)
                    {
                        TypeName = "Javeling";
                    }
                    else if (Type == 6)
                    {
                        TypeName = "Spear";
                    }
                    else if (Type == 7)
                    {
                        TypeName = "Sickle";
                    }
                    else if (Type == 8)
                    {
                        TypeName = "Knife";
                    }
                    else if (Type == 9)
                    {
                        TypeName = "Claws";
                    }
                    else TypeName = "Invalid Type";
                }
            }
               
        }
        
      
    }
}
