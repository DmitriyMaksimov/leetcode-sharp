using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02099Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02099();
        sut.MaxSubsequence(new[] {2, 1, 3, 3}, 2).Should().Equal(3, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02099();
        sut.MaxSubsequence(new[] {-1, -2, 3, 4}, 3).Should().Equal(-1, 3, 4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02099();
        sut.MaxSubsequence(new[] {3, 4, 3, 3}, 2).Should().Equal(3, 4);
    }
}