using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int target;
            var nums = GetNumbers(100000000, out target);
            DateTime before = new DateTime();
            DateTime after = new DateTime();

            before = DateTime.Now;
            Console.WriteLine(Array.BinarySearch(nums, target));
            after = DateTime.Now;
            Console.WriteLine(after - before);

            Console.WriteLine();

            before = DateTime.Now;
            Console.WriteLine(SearchInsert(nums, target));
            after = DateTime.Now;
            Console.WriteLine(after - before);
        }

        static int[] GetNumbers(int size, out int target)
        {
            int[] numbers = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(Int32.MaxValue - 1);
            }
            target = random.Next();
            numbers[random.Next(size)] = target;
            Array.Sort(numbers);
            return numbers;
        }

        static int SearchInsert(int[] nums, int target)
        {
            int low = 0, up = nums.Count() - 1;
            int mid;
            while (low < up)
            {
                mid = (low + up) / 2;
                if (target < nums[mid]) up = mid;
                else if (target > nums[mid]) low = mid + 1;
                else return mid;
            }
            if (target > nums[low]) return low + 1;
            else return low;
        }
    }
}
