public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hashSet = new();

        for(int i=0; i<nums.Length; i++)    
        {
            hashSet.Add(nums[i]);
        }
        int seq=1, lseq=0, num=0;

        // Iterating over hashset will avoid the duplicate values.
        foreach(var n in hashSet)
        {
            num = n;
            if(!hashSet.Contains(num - 1))
            {
                seq=1;
                while(hashSet.Contains(num + 1))
                {
                    num = num + 1;
                    seq++;
                }
                lseq = Math.Max(lseq, seq);
            }
        }
        return lseq;
    }
}
