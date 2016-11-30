using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class Backpack
    {

        public List<BaseItem> Items = new List<BaseItem>();

        public int MaxSlots;
        public Backpack()
        {

            
        }




   
        public void Add(BaseItem NewItem,int Count)
        {
            if(Items.Count <= MaxSlots)
            {
                foreach (var item in Items)
                {
                    if(item.Item_Name == NewItem.Item_Name)
                    {
                        if(item.is_Stackable == true && item.Item_Count < item.Max_StackSize)
                        {
                            item.Item_Count += Count;
                        }
                        else
                        {
                            Items.Add(NewItem);
                        }
                    }
                }
                Items.Add(NewItem);
            }          
        }

        private void Remove(BaseItem item,int Count)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items.Count > 0)
                {
                    Items[i].Item_Count -= Count;
                }
                else
                {
                    Items.Remove(item);
                }
            }
        }
    }
}
