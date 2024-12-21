public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        foreach (var number in nums)
        {
            if(number != val)
            {
                nums[k] = number;
                k++;
            }
        }   
        return k;
    }
}