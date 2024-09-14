using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02419Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02419();
        sut.LongestSubarray([1, 2, 3, 3, 2, 2]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02419();
        sut.LongestSubarray([1, 2, 3, 4]).Should().Be(1);
    }
}
