using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace GradientColorStudio
{
    class PreviousColors
    {
        private readonly ColorTable colorTable = new ColorTable();

        public bool LoadList()
        {
            if (File.Exists(Statics.dataFile))
            {
                string[] lines = File.ReadAllLines(Statics.dataFile);
                string[] delimeters;

                foreach (string line in lines)
                {
                    delimeters = new[] { "*" };
                    colorTable.AddRow(new List<string>(line.Split(delimeters, StringSplitOptions.None)));
                }

                return true;
            }
            return false;
        }

        public void SaveList()
        {
            if (File.Exists(Statics.dataFile))
            {
                try
                {
                    File.WriteAllText(Statics.dataFile, colorTable.ToString());
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + " error");
                }
            }
            else
            {
                File.Create(Statics.dataFile).Close();
                SaveList();
            }
        }

        public List<Color> GetRow(int index)
        {
            List<Color> row = new List<Color>();
            List<string> rTemp = colorTable.GetRow(index);
            int rTempCount = rTemp.Count;

            for (int i = 0; i < rTempCount; i++)
            {
                row.Add(ColorTranslator.FromHtml(rTemp[i]));
            }

            return row;
        }

        public int RowCount()
        {
            return colorTable.GetCount();
        }

        public void AddColor(Color[] colors)
        {
            List<string> row = new List<string>();
            int colorsLength = colors.Length;

            for (int i = 0; i < colorsLength; i++)
            {
                row.Add(ColorTranslator.ToHtml(colors[i]));
            }

            if (colorTable.GetCount() >= 10)
            {
                colorTable.DeleteRow(0);
            }

            colorTable.AddRow(row);
        }
    }
}
