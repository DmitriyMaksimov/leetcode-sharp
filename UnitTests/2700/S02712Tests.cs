using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02712Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02712();
        Assert.That(sut.MinimumCost("0011"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02712();
        Assert.That(sut.MinimumCost("010101"), Is.EqualTo(9));
    }
}
