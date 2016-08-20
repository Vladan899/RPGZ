using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class ItemFactory
    {

        public List<BaseItem> Items = new List<BaseItem>();
        Random random = new Random();

        public ItemFactory()
        {


            //Items.Add(new (BaseItem)Armor());
        }

        public void GenerateArmor(byte Rarity, byte ArmorType, int teir)
        {
            BaseItem item = new BaseItem();
            item.ItemType = 0;
            item.tier = (byte)random.Next(0, teir);
            item.type = (byte)random.Next(0, ArmorType);

            item.Name = item.tierName + " " + item.typeName;
            item.StackSize = 1;
            item.IsStackable = false;
            item.Lore = "New Item";
            item.type = ArmorType;
        }
    }
}
