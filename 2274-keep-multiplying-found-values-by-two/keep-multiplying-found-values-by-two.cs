public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        // var int found=nums.FirstOrDefault(original);
        // var int temp;
        
        while(nums.Contains(original))
        {
            original=original*2;
        }
        return original;
        
    }
}