using System.Collections;

namespace _268._Missing_Number
{
    internal class Program
    {
        static public int MissingNumber(int[] nums)
        {
            
            Array.Sort(nums);
            
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i) return i;
            }
            return nums.Length;
        }
        static void Main(string[] args)
        {
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Console.WriteLine(MissingNumber(nums));
        }
    }
}