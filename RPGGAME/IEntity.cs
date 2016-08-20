using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGAME
{
    class IEntity : IAttributes
    {
        private int Level;
        public int level
        {
            get
            {
                return Level;
            }

            set
            {
                Level = value;
            }
        }

        private int Expiriance;
        public int expiriance
        {
            get
            {
                return Expiriance;
            }

            set
            {
                Expiriance = Expiriance -= (int)NextEXP;
            }
        }
        public float NextEXP;
        public float next_exp
        {
            get
            {
                return NextEXP;
            }

            set
            {
                NextEXP = value;
            }
        }
        private int[] BaseAttr;
        public int[] BaseAttributes
        {
            get
            {
                return BaseAttr;
            }

            set
            {
                BaseAttr = value;
            }
        }
        private float[] OtherAttr;
        public float[] OtherAttributes
        {
            get
            {
                return OtherAttr;
            }

            set
            {
                OtherAttr = value;
            }
        }

        public void Update(GameTime gameTIme)
        {
            UpdateNextLevel(1.1f);
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        public void UpdateNextLevel(float Multipiler)
        {
            while(Expiriance >= NextEXP)
            {
                Level++;
                Expiriance = Expiriance - (int)NextEXP;
                NextEXP = NextEXP * Multipiler;
            }
        }

        public void HandeInput()
        {
           
        }
    }
}
