public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int[] buffer = new int[m];
        for(int i = 0; i < m; i++)
            buffer[i] = nums1[i];

        int buffer_index = 0;
        int nums2_index = 0;

        for(int i = 0; i < nums1.Length; i++){
            bool nums1IsBigger;

            if(buffer_index >= m) nums1IsBigger = true;
            else if (nums2_index >= n) nums1IsBigger = false;
            else if(buffer_index >= m) nums1IsBigger = true;
            else nums1IsBigger = buffer[buffer_index] > nums2[nums2_index];

            if(nums1IsBigger){
                nums1[i] = nums2[nums2_index];
                nums2_index++;
            }
            else{
                nums1[i] = buffer[buffer_index];
                buffer_index++;
            }
        }
    }
}