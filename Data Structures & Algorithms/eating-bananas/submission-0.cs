public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left=0, right=piles.Max()-1;
        int k=0, mid=0, temp=0;

        while(left <= right)    
        {
            mid= (left + right)/2;
            k=0;
            for(int i=0; i<piles.Length; i++)
            {
                Console.WriteLine((int)Math.Ceiling(piles[i]/((mid+1) * 1.0)));
                k += (int)Math.Ceiling(piles[i]/((mid+1) * 1.0));
            }
            Console.WriteLine("k =" + k);
            if(h >= k)
            {
                temp = mid+1;
                right = mid-1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return temp;
    }
}
