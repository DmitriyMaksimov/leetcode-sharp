using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02606Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02606();
        sut.MaximumCostSubstring("adaa", "d", [-1000]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02606();
        sut.MaximumCostSubstring("abc", "abc", [-1, -1, -1]).Should().Be(0);
    }
}
