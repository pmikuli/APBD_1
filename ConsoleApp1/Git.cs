using System.Runtime.InteropServices;

public class Git {
    public void Test() {
        Console.WriteLine("Test");
    }

    public void Status() {
        // TODO implement
    }

    public static int Average(int[] nums) {
        var sum = 0;
        for (int it = 0; it < nums.Length; it++) {
            sum += nums[it];
        }
        return sum / nums.Length;
    }

    public static int Max(int[] nums) {
        var max = nums[0];
        for (int i = 0; i < nums.Length; i++) {
            max = nums[i] > max ? nums[i] : max;
        }
        return max;
    }
}