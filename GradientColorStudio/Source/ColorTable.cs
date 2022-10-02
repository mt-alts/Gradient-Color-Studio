using System;
using System.Collections.Generic;

namespace GradientColorStudio
{
    class ColorTable
    {
        private readonly List<List<string>> table = new List<List<string>>();

        public void AddRow(List<string> row)
        {
            table.Add(row);
        }

        public List<string> GetRow(int index)
        {
            if (index < table.Count)
            {
                return table[index];
            }

            throw new IndexOutOfRangeException();
        }

        public void DeleteRow(int index)
        {
            if (table.Count >= index)
            {
                table.RemoveAt(index);
            }
        }

        public int GetCount()
        {
            return table.Count;
        }

        public List<List<string>> GetTable()
        {
            return table;
        }

        public override string ToString()
        {
            string line = "";
            List<string> tempR;
            int columnCount = table.Count;
            int rowCount = 0;

            for (int i = 0; i < columnCount; i++)
            {
                tempR = table[i];
                rowCount = tempR.Count;

                for (int j = 0; j < rowCount; j++)
                {
                    if ((rowCount - 1) != j)
                    {
                        line += tempR[j] + "*";
                    }
                    else
                    {
                        line += tempR[j];
                    }
                }

                line += System.Environment.NewLine;
            }

            return line;
        }
    }
}
