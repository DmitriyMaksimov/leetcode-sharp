namespace leetcode_sharp;

// 1095. Find in Mountain Array
// https://leetcode.com/problems/find-in-mountain-array
public class S01095
{
    public class MountainArray
    {
        private readonly IList<int> _list;

        public MountainArray(IList<int> list)
        {
            _list = list;
        }
        
        public int Get(int index)
        {
            return _list[index];
        }

        public int Length()
        {
            return _list.Count;
        }
    }

    public int FindInMountainArray(int target, MountainArray mountainArr)
    {
        var peak = peakIndex(mountainArr);
        var index = binarySearch(mountainArr, target, 0, peak);

        return index != -1 ? index : binarySearch(mountainArr, target, peak + 1, mountainArr.Length() - 1);
    }

    private static int peakIndex(MountainArray mountainArray)
    {
        var si = 0;
        var ei = mountainArray.Length() - 1;
        while (si < ei)
        {
            var mid = si + (ei - si) / 2;
            if (mountainArray.Get(mid) > mountainArray.Get(mid + 1))
            {
                ei = mid;
            }
            else
            {
                si = mid + 1;
            }
        }

        return si;
    }

    private static int binarySearch(MountainArray mountainArray, int target, int si, int ei)
    {
        var isAsc = mountainArray.Get(si) < mountainArray.Get(ei);
        while (si <= ei)
        {
            var mid = si + (ei - si) / 2;
            if (target == mountainArray.Get(mid))
            {
                return mid;
            }

            if (isAsc)
            {
                if (target > mountainArray.Get(mid))
                {
                    si = mid + 1;
                }
                else
                {
                    ei = mid - 1;
                }
            }
            else
            {
                if (target > mountainArray.Get(mid))
                {
                    ei = mid - 1;
                }
                else
                {
                    si = mid + 1;
                }
            }
        }

        return -1;
    }
}
