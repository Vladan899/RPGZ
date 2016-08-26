using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public class BaseItems
    {
        public byte itemType { get; set; }
        public byte ItemSubType { set; get; }
        public string itemName { get; set; }
        public string description { get; set; }
        public bool isStackable { get; set; }
        public int stackCount { get; set; }
        public Animations Sprite { get; set; }


        
    }
}
