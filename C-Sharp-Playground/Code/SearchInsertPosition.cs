namespace C_Sharp_Playground.Code
{
    public class SearchInsertPosition
    {
         public static int  searchInsertPosition(int[] nums,int  target)
    {
        int index  = Array.IndexOf(nums,target);
        int minDistance = (from c in nums where target-c>0 select c).DefaultIfEmpty().Max();
        int minDistanceIndex  = EqualityComparer<int>.Default.Equals(minDistance, 0)?0: Array.IndexOf(nums,minDistance)+1;
       return index switch{
           -1=>minDistanceIndex,
           >=0=>index
        };
      
    }
    }
}