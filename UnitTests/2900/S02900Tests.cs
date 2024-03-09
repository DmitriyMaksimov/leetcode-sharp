using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02900Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02900();
        sut.GetLongestSubsequence(["e", "a", "b"], [0, 0, 1]).Should().Equal("e", "b");
    }

    [Test]
    public void T2()
    {
        var sut = new S02900();
        sut.GetLongestSubsequence(["a", "b", "c", "d"], [1, 0, 1, 1]).Should().Equal("a", "b", "c");
    }
}