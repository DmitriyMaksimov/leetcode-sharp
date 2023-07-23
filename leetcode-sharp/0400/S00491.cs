namespace leetcode_sharp;

// 491. Non-decreasing Subsequences
// https://leetcode.com/problems/non-decreasing-subsequences/
public class S00491
{
    private class SequenceComparer<T>:IEqualityComparer<IEnumerable<T>>
    {
        public bool Equals(IEnumerable<T> seq1,IEnumerable<T> seq2)
        {
            return seq1.SequenceEqual(seq2);
        }
    
        public int GetHashCode(IEnumerable<T> seq)
        {
            return seq.Aggregate(1234567, (current, elem) => unchecked(current * 37 + elem.GetHashCode()));
        }
    }
    
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        var result = new HashSet<IList<int>>(new SequenceComparer<int>());
        
        var numberOfVariants = (int)Math.Pow(2, nums.Length);
        
        for (var bitMask = 1; bitMask < numberOfVariants; bitMask++)
        {
            var mask = numberOfVariants / 2;
            var list = new List<int>();
            
            for (var bit = 0; bit < nums.Length; bit++)
            {
                if ((bitMask & mask) != 0)
                {
                    if (list.Any())
                    {
                        if (list.Last() > nums[bit])
                        {
                            list.Clear();
                            break;
                        }
                    }
                    list.Add(nums[bit]);
                }

                mask >>= 1;
            }

            if (list.Count > 1)
            {
                result.Add(list);                        
            }
        }

        return result.ToArray();
    }
}