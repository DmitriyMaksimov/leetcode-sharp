using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02222Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02222();
        Assert.That(sut.NumberOfWays("001101"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02222();
        Assert.That(sut.NumberOfWays("11100"), Is.EqualTo(0));
    }
}
