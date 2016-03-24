using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using C3.XNA;

namespace BigBros
{
    class ScreenManager
    {
        private SpriteBatch m_SpriteBatch;

        public void Init(GraphicsDevice device, ContentManager content)
        {
            m_SpriteBatch = new SpriteBatch(device);


        }

        public void Update(Game1 game1)
        {

        }

        public void Draw()
        {
            DrawUI();
        }

        private void DrawUI()
        {
            m_SpriteBatch.Begin();

            m_SpriteBatch.End();
        }
    }
}
