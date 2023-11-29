using System;

namespace TernarySearch
{
    public class Ternary
    {
        public static int TernarySearch(int l, int r, int key, int[] ar)
        {
            if (r >= l)
            {
                int mid1 = l + (r - l) / 3;
                int mid2 = r - (r - l) / 3;

                if (ar[mid1] == key)
                {
                    return mid1;
                }

                if (ar[mid2] == key)
                {
                    return mid2;
                }

                if (key < ar[mid1])
                {
                    return TernarySearch(l, mid1 - 1, key, ar);
                }
                else if (key > ar[mid2])
                {
                    return TernarySearch(mid2 + 1, r, key, ar);
                }
                else
                {
                    return TernarySearch(mid1 + 1, mid2 - 1, key, ar);
                }
            }

            return -1;
        }
    }
}