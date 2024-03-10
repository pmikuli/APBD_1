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
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
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