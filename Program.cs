// See https://aka.ms/new-console-template for more information



namespace leetcodesolutions;

public class Program
{

   
    public static void Main(string[] args)
    {

        //~~~~~3151 Special Array I~~~~~~


        // Create an instance of Program to call non-static method
        Program program = new Program();

        // Test array
        int[] nums = {1,1,6,9};

        //instantiate object
        SpecialArrayI specialArrayI = new SpecialArrayI();

        //call method
        bool result = specialArrayI.IsArraySpecial(nums);
        Console.WriteLine($"Is array special: {result}");
    }
    
}
