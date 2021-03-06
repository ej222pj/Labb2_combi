﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combination.Content.View
{
    class Camera
    {
        private float scale;
        private static int border = 10;

        public Camera(int width, int heigth)
        {
            int scaleX = (width - border * 2);
            int scaleY = (heigth - border * 2);

            scale = scaleX;
            if (scaleY < scaleX)
            {
                scale = scaleY;
            }
        }

        public Rectangle scaleParticle(float xPos, float yPos, float size)
        {
            int vSize = (int)(size * scale);

            Vector2 smokeVector = scaleVector(xPos, yPos);

            return new Rectangle((int)smokeVector.X, (int)smokeVector.Y, vSize, vSize);
        }

        public Vector2 scaleVector(float xPos, float yPos)
        {
            float X = (xPos * scale + border);
            float Y = (yPos * scale + border);

            return new Vector2(X, Y);
        }

        public float Scale
        {
            get { return scale; }
        }
    }
}
