using System.Numerics;

namespace leetcode_sharp;

// 1286. Iterator for Combination
// https://leetcode.com/problems/iterator-for-combination
public class S01286
{
    public class CombinationIterator
    {
        private readonly IEnumerable<string> combinations;
        private readonly IEnumerator<string> enumerator;
        private bool hasNext;

        public CombinationIterator(string characters, int combinationLength)
        {
            combinations = Generate(characters, combinationLength).Order();
            enumerator = combinations.GetEnumerator();
            hasNext = enumerator.MoveNext();
        }

        public string Next()
        {
            var current = enumerator.Current;
            hasNext = enumerator.MoveNext();
            return current;
        }

        public bool HasNext()
        {
            return hasNext;
        }

        private static IEnumerable<string> Generate(string characters, int combinationLength)
        {
            for (var mask = 0u; mask < 1 << characters.Length; mask++)
            {
                if (BitOperations.PopCount(mask) != combinationLength)
                {
                    continue;
                }

                var combination = "";
                for (var i = 0; i < characters.Length; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        combination += characters[i];
                    }
                }

                yield return combination;
            }
        }
    }
}