using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01865Tests
{
    [Test]
    public void T1()
    {
        var findSumPairs = new S01865.FindSumPairs([1, 1, 2, 2, 2, 3], [1, 4, 5, 2, 5, 4]);
        findSumPairs.Count(7).Should().Be(8); // return 8; pairs (2,2), (3,2), (4,2), (2,4), (3,4), (4,4) make 2 + 5 and pairs (5,1), (5,5) make 3 + 4
        findSumPairs.Add(3, 2); // now nums2 = [1,4,5,4,5,4]
        findSumPairs.Count(8).Should().Be(2); // return 2; pairs (5,2), (5,4) make 3 + 5
        findSumPairs.Count(4).Should().Be(1); // return 1; pair (5,0) makes 3 + 1
        findSumPairs.Add(0, 1); // now nums2 = [2,4,5,4,5,4]
        findSumPairs.Add(1, 1); // now nums2 = [2,5,5,4,5,4]
        findSumPairs.Count(7).Should().Be(11); // return 11; pairs (2,1), (2,2), (2,4), (3,1), (3,2), (3,4), (4,1), (4,2), (4,4) make 2 + 5 and pairs (5,3), (5,5) make 3 + 4
    }
}
