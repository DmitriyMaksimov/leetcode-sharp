using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00006();
        Assert.That(sut.Convert("PAYPALISHIRING", 3), Is.EqualTo("PAHNAPLSIIGYIR"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00006();
        Assert.That(sut.Convert("PAYPALISHIRING", 4), Is.EqualTo("PINALSIGYAHRPI"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00006();
        Assert.That(sut.Convert("A", 1), Is.EqualTo("A"));
    }
}