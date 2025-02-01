using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02578Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02578();
        Assert.That(sut.SplitNum(4325), Is.EqualTo(59));
    }

    [Test]
    public void T2()
    {
        var sut = new S02578();
        Assert.That(sut.SplitNum(687), Is.EqualTo(75));
    }
}