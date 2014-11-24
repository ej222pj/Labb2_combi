using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Combination.Content.View
{
    class ExplotionSystem
    {
        private Vector2 position;
        //private SmokeSystem smokeSystem;
        //Add Schockwave
        private SplitterSystem splitterSystem;
        private ExplotionParticle explotionParicle;

        public ExplotionSystem(Viewport viewPort, ContentManager content)
        {
            position = new Vector2(0.5f, 0.5f);
            //smokeSystem = new SmokeSystem(viewPort, position, content);
            //add schockwave
            splitterSystem = new SplitterSystem(viewPort, position, content);
            explotionParicle = new ExplotionParticle(viewPort, position, content);                
        }

        public void Update(float timeElapsed)
        {
            //smokeSystem.Update(timeElapsed);  
            //Add shockwave
            
        }

        public void Draw(SpriteBatch spriteBatch, float timeElapsed)
        {
            //smokeSystem.Draw(spriteBatch);
            //add Shockwave
            splitterSystem.Draw(spriteBatch, timeElapsed);
            explotionParicle.Draw(spriteBatch, timeElapsed);
        }
    }
}
