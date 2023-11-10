namespace C_Sharp_Playground.Code
{
    public class RecordCounter
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int maxScore = scores[0];
            int minScore = scores[0];
            List<int> recordSheet = new List<int> { 0, 0 };

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    recordSheet[0]++;
                }
                else if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    recordSheet[1]++;
                }
                Console.WriteLine(string.Join(',', recordSheet));
            }

            return recordSheet;
        }
    }
}