using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01686Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01686();
        sut.StoneGameVI([1, 3], [2, 1]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01686();
        sut.StoneGameVI([1, 2], [3, 1]).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01686();
        sut.StoneGameVI([2, 4, 3], [1, 6, 7]).Should().Be(-1);
    }
}
