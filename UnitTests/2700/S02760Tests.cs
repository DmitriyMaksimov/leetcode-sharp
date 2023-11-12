using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02760Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02760();
        sut.LongestAlternatingSubarray(new[] {3, 2, 5, 4}, 5).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02760();
        sut.LongestAlternatingSubarray(new[] {1, 2}, 2).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02760();
        sut.LongestAlternatingSubarray(new[] {2, 3, 4, 5}, 4).Should().Be(3);
    }
}