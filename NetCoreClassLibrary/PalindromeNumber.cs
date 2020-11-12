
namespace Playground
{
    public class PalindromeNumber
    {
        public bool IsPalindromeReverse(int x) // Faster
        {
            if (x < 0) return false;

            var a = new System.Collections.Generic.List<int>();

            while (x > 0)
            {
                a.Add(x % 10);

                x /= 10;
            }

            int mid = a.Count / 2;
            var top = a.Count - 1;

            for (int i = 0; i < mid; i++)
            {
                if (a[i] != a[top - i]) return false; 
            }

            return true;
        }

        public bool IsPalindromeReverseHalf(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            var a = 0;

            while (x > a)
            {
                a = a * 10 + (x % 10);

                x /= 10;
            }

            return a == x || (a / 10) == x;
        }

    }
}