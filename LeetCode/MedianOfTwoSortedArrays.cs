public class MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int nums1Length = nums1.Length;
        int nums2Length = nums2.Length;

        if (nums1Length > nums2Length)
        {
            return FindMedianSortedArrays(nums2, nums1); // Ensure nums1 is the shorter array
        }

        int low = 0;
        int high = nums1Length;
        int targetLeftHalfLen = (nums1Length + nums2Length + 1) / 2;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = targetLeftHalfLen - partitionX;

            int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int minRightX = (partitionX == nums1Length) ? int.MaxValue : nums1[partitionX];

            int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minRightY = (partitionY == nums2Length) ? int.MaxValue : nums2[partitionY];

            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                if ((nums1Length + nums2Length) % 2 == 0)
                {
                    return (double)(Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                }
                else
                {
                    return Math.Max(maxLeftX, maxLeftY);
                }
            }
            else if (maxLeftX > minRightY)
            {
                high = partitionX - 1;
            }
            else
            {
                low = partitionX + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted correctly.");
    }



}

