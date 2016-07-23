using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    public class EntityBase
    {
        protected int Level;
        protected Animations animations;
        

        public virtual void Update(GameTime gameTime)
        {

        } 

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }


    }
}
