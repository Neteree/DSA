public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int leftIndex = 0;
        int rightIndex = numbers.Length - 1;

        while(numbers[leftIndex] + numbers[rightIndex] != target)
        {
            if(numbers[leftIndex] + numbers[rightIndex] < target)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return [leftIndex + 1, rightIndex + 1];
    }
}
