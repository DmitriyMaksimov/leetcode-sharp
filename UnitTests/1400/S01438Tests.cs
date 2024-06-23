using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01438Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01438();
        sut.LongestSubarray([8, 2, 4, 7], 4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01438();
        sut.LongestSubarray([10, 1, 2, 4, 7, 2], 5).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S01438();
        sut.LongestSubarray([4, 2, 2, 2, 4, 4, 2, 2], 0).Should().Be(3);
    }
}