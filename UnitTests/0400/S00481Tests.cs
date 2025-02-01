using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00481Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00481();
        Assert.That(sut.MagicalString(6), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00481();
        Assert.That(sut.MagicalString(1), Is.EqualTo(1));
    }
}
