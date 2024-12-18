using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02712Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02712();
        sut.MinimumCost("0011").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02712();
        sut.MinimumCost("010101").Should().Be(9);
    }
}
