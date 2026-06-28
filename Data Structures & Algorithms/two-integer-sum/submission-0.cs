public class Solution {
    Dictionary<int,int> map = new Dictionary<int,int>();
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            int sum = target-nums[i];
            if(map.ContainsKey(sum)){
                return new[] {map[sum],  i};
            }
         map[nums[i]] =i;

        }
    return null;


    }
}
