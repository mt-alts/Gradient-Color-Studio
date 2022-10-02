using System;
using System.Collections.Generic;
using System.Drawing;

namespace GradientColorStudio
{
    class RandomColorGenerator : List<Color>
    {
        readonly Random random = new Random();

        public RandomColorGenerator(int colorCount)
        {
            int r, g, b;

            for (int i = 0; i < colorCount; i++)
            {
                r = random.Next(0, 255);
                g = random.Next(0, 255);
                b = random.Next(0, 255);
                Add(Color.FromArgb(r, g, b));
            }
        }
    }
}
