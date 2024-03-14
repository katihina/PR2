// Задание 1
using System;

class Program1
{
    static void Main()
    {
        string j = "aC";
        string s = "aBbmoCaaUCc";
        
        int count = 0;
        foreach (char c in s)
        {
            if (j.Contains(c))
            {
                count++;
            }
        }
        
        Console.WriteLine($"Количество {j} в {s}: {count}");
    }
}

// Задание 2
using System;

class Program2
{
    static void FindCombinations(int[] candidates,int target,int start, int currentSum,int[] currentCombination)
    {
        if (currentSum == target)
        {
            
            for (int i = 0; i < currentCombination.Length; i++)
            {
                if (currentCombination[i] != 0)
                {
                    Console.Write(currentCombination[i] + " ");
                }
            }
            Console.WriteLine();
            
            return;
        }

        if (currentSum > target || start >= candidates.Length)
        {
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            currentCombination[i] = candidates[i];
            FindCombinations(candidates, target, i + 1, currentSum + candidates[i], currentCombination);
            currentCombination[i] = 0;
        }
    }

    static void Main()
    {
        int[] candidates = {2,9,5,6,8,7,1,10};
        int target = 7;
        int[] currentCombination = new int[candidates.Length];

        FindCombinations(candidates,target,0,0,currentCombination);
    }
} 

// Задание 3
using System;

class Program3
{
    static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        int[] nums = {2,6,7,3,8,5,6,2};
        bool result = ContainsDuplicate(nums);

        Console.WriteLine(result);
    }
}