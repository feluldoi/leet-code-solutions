﻿// See https://aka.ms/new-console-template for more information



namespace leetcodesolutions;

public class Program
{




    //~~~~~3151 Special Array I~~~~~~
    public static void Main(string[] args)
    {
        // Create an instance of Program to call non-static method
        Program program = new Program();

        // Test array
        int[] nums = {1,1,6,9};

        // Call your method and print result
        bool result = program.IsArraySpecial(nums);
        Console.WriteLine($"Is array special: {result}");
    }



    public bool IsArraySpecial(int[] nums)
    {
        bool result = false;

        //output true if only one element
        if (nums.Length == 1)
        {
            return true;
        }
        //handle two elements case
        else if (nums.Length == 2)
        {
            int first = nums[0] % 2;
            int second = nums[1] % 2;

            if (first == second)
            {
                return false;
            }
            else if (first != second)
            {
                return true;
            }
        }
        else
        {
            //start at index 1 to prevent array out of index. total length is 3 so -1 to prevent array out of index
            for (int i = 1; i < nums.Length - 1; i++)
            {

                //modulo left value
                int leftValue = nums[i - 1];
                int leftModResult = leftValue % 2;
                //modulo right value
                int rightValue = nums[i + 1];
                int rightModResult = rightValue % 2;

                //modulo pivot value
                int pivotModValue = nums[i] % 2;

                //special case
                if (leftModResult == 0 & pivotModValue != 0 & rightModResult == 0)
                {
                    result = true;
                }
                //special case 
                else if (leftModResult != 0 & pivotModValue == 0 & rightModResult != 0)
                {
                    result = true;
                }
                //every other case return false
                else
                {
                    result = false;
                    //leave loop after the first case of a non special array
                    break;
                }



            }
        }
            return result;
    }
}
