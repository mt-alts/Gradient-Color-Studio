using System.Drawing;
using System.Text.RegularExpressions;

namespace GradientColorStudio
{
    class ColorTranslator2
    {
        public static Color StringToRgb(string color)
        {
            string[] values = Regex.Split(color, @"\D+");
            int[] argb = new int[values.Length];
            int argbLength = argb.Length - 1;

            for (int i = 1; i < argbLength; i++)
            {
                argb[i] = int.Parse(values[i]);
            }

            return Color.FromArgb(argb[0], argb[1], argb[2], argb[3]);
        }

        public static Color Invertion(Color color)
        {
            int colorValue = color.R + color.G + color.B;

            if (colorValue < 300)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }
    }
}
