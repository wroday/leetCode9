public class leetCode9 {
    public static bool IsPalindrome(int x) {
        long original = x;
        long reversed = 0;

        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return original == reversed;
    }
}