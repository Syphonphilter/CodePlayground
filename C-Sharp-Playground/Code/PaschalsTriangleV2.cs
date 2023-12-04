namespace C_Sharp_Playground.Code
{
    public class PaschalsTriangleV2
    {
        public IList<int> GetRow(int numRows)
        {
            List<int> row = new List<int>();
            List<int> current = new List<int>();

            for (int i = 1; i <= numRows + 1; i++)
            {
                List<int> cells = new List<int>();
                int elementsToMid = (i + 1) / 2;

                if (i <= 2)
                {
                    current.Add(1);
                    cells = current;
                }
                else
                {
                    cells.Add(1);

                    for (int j = 0; j < elementsToMid - 1; j++)
                    {
                        cells.Add(current[j] + current[j + 1]);
                    }

                    List<int> rcells = i % 2 == 0 ? new List<int>(cells) : cells.Take(cells.Count - 1).ToList();
                    rcells.Reverse();
                    cells.AddRange(rcells);
                }

                current = cells;
            }

            row.AddRange(current);
            return row;
        }
    }
}
