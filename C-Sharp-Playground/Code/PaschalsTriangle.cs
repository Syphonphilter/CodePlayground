namespace C_Sharp_Playground.Code
{
    public class PaschalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<List<int>> row = new List<List<int>>();
            // current list state
            List<int> current = new List<int>();
            for (int i = 1; i <= numRows; i++)
            {
                List<int> cells = new List<int>();
                int elementsToMid = i % 2 == 0 ? i / 2 : Math.Abs(i / 2) + 1;
                if (i <= 2)
                {
                    current.Add(1);
                    cells = current;
                }
                else
                {
                    cells.Add(1);
                    for (int j = 0; j <= elementsToMid - 1; j++)
                    {
                        if (j == elementsToMid - 1)
                        {
                            Console.WriteLine(j);
                        }
                        else
                        {
                            cells.Add(current[j] + current[j + 1]);
                        }
                    }
                    List<int> rcells = i % 2 == 0 ? new List<int>(cells) : cells.Take(cells.Count - 1).ToList();
                    rcells.Reverse();
                    cells.AddRange(rcells);
                }
                row.Add(new List<int>(cells));
                current = cells;

            }
            return row.ToArray();
        }
    }
}