using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGHAME
{
    public class Animations
    {


        Texture2D texture;
        double timeElapsed;
        float timeToUpdate;
        int currentFrame;

        public float FramePerSecond
        {
           
            set { timeToUpdate = 1f / value; }
        }
        string CurrentAnimation;

        Dictionary<string, Rectangle[]> zAnimations = new Dictionary<string, Rectangle[]>();



        public void AddAnimation(string Name, int frames, int startFrame, int Ypos, int Width, int Height)
        {
            
            Rectangle[] rectangles = new Rectangle[frames];

            for (int i = 0; i < frames; i++)
            {
                rectangles[i] = new Rectangle((i + startFrame) * Width, Ypos, Width, Height);
            }
            zAnimations.Add(Name, rectangles);
        }


        public void UpdateAnimation(GameTime gt, Rectangle BBox, Vector2 pos)
        {
            BBox = new Rectangle((int)pos.X, (int)pos.Y, texture.Width, texture.Height);

            timeElapsed += gt.ElapsedGameTime.TotalSeconds;
            if (timeElapsed > timeToUpdate)
            {
                timeElapsed -= timeToUpdate;
                if (currentFrame < zAnimations[CurrentAnimation].Length - 1)
                {
                    currentFrame++;
                }
                else
                {
                    currentFrame = 0;
                }
            }
        }

        public void Draw(SpriteBatch sp, Vector2 position)
        {
            sp.Draw(texture, position, zAnimations[CurrentAnimation][currentFrame], Color.White);
        }


        public void PlayAnimation(string name)
        {
            if (CurrentAnimation != name)
            {
                CurrentAnimation = name;
                currentFrame = 0;
            }
        }

    }
}

