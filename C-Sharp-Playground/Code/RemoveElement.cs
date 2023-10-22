namespace C_Sharp_Playground.Code
{
    public class RemoveElement
    {
        
    public static int removeElement1_notInSpace(int[] nums, int val) {
        int k = 0;
        int l = 0 ;
        if(nums.Length==0){
            return 0;
        }
        l = nums.Length;
        nums = (from c in nums where c!= val select c).ToArray();
        k = nums.Length==0? 0: nums.Length;
        for(int i =k; i<l;i++){
            Array.Resize(ref nums, nums.Length+1);
          nums[nums.Length-1]=k++; 
        }
        Array.Sort(nums,0,k);
        Console.WriteLine(string.Join(',',nums));
        return k;
       
    }
    public static int removeElement2_inSpace(int[] nums, int val) {
    int k = 0;

    for (int i = 0; i < nums.Length; i++) {
        if (nums[i] != val) {
            nums[k] = nums[i];
            k++;
        }
    }

    // Sort only the first 'k' elements
    Array.Sort(nums, 0, k);
    Console.WriteLine(string.Join(',', nums));
    return k;
}

    }
}