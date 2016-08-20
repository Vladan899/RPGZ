using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    public interface IAttributes
    {
        int level { get; set; }
        int expiriance { get; set; }
        float next_exp { get; set; }
       

        int[] BaseAttributes { get; set; }
        float[] OtherAttributes { get; set; }
        /// <summary>
        /// Hero,Monster, Interactive NPC, Specail, Elite, Boss
        /// </summary>
        int EntityType { get; set; }

        void UpdateNextLevel(float multipiler);

    }
}