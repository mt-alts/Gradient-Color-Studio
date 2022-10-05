using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace GradientColorStudio
{
    class ColorBlender
    {
        private Bitmap bitmap;
        private readonly Color[] colors;
        private float[] positions;

        public EGradientStyle GradientStyle { get; set; }
        public Size BitmapSize
        {
            set => bitmap = new Bitmap(value.Width, value.Height);
        }

        public ColorBlender(List<Color> colorList)
        {
            bitmap = new Bitmap(Statics.COLOR_RENDERER_SIZE.Width, Statics.COLOR_RENDERER_SIZE.Height);
            colors = new Color[colorList.Count];

            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = colorList[i];
            }
        }

        private void ColorPositions()
        {
            positions = new float[colors.Length];
            float difference = 1.0f / positions.Length;
            positions[0] = 0.0f;

            if (positions.Length != 3)
            {
                for (int i = 1; i < positions.Length - 1; i++)
                {
                    positions[i] = positions[i - 1] + difference;
                }
            }
            else
            {
                positions[1] = 0.5f;
            }

            positions[positions.Length - 1] = 1.0f;
        }

        public Bitmap BlendBitmap()
        {
            if (GradientStyle == EGradientStyle.LINEAR)
            {
                ColorPositions();
            }

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

                switch (GradientStyle)
                {
                    case EGradientStyle.LINEAR:
                        LinearGradientBrush lgb = new LinearGradientBrush(rectangle, Color.Transparent, Color.Transparent, 360);
                        ColorBlend colorBlend = new ColorBlend(colors.Length);
                        colorBlend.Colors = colors;
                        colorBlend.Positions = positions;
                        lgb.InterpolationColors = colorBlend;
                        graphics.FillRectangle(lgb, rectangle);
                        lgb.Dispose();
                        graphics.Dispose();
                        break;
                    case EGradientStyle.MIXED:
                        GraphicsPath graphicsPath = new GraphicsPath();
                        graphicsPath.AddRectangle(rectangle);
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            using (PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath))
                            {
                                pathGradientBrush.CenterColor = Color.FromArgb((int)colors.Average(a => a.R), (int)colors.Average(a => a.G), (int)colors.Average(a => a.B));
                                pathGradientBrush.SurroundColors = colors;
                                g.FillPath(pathGradientBrush, graphicsPath);
                                g.Dispose();
                            }
                        }
                        break;
                }
            }

            return bitmap;
        }
    }
}
