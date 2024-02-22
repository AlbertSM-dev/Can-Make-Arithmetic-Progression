public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int Diff = arr[1] - arr[0];
        if(arr.Length == 2)
        {
            return true;
        }
        for(int i = 2; i < arr.Length; i++)
        {
            if(arr[i] - arr[i - 1] != Diff)
            {
                return false;
            }
        }
        return true;
    }
}
