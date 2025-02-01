using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00278Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00278(4);
        Assert.That(sut.FirstBadVersion(5), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00278(1);
        Assert.That(sut.FirstBadVersion(1), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00278(2);
        Assert.That(sut.FirstBadVersion(3), Is.EqualTo(2));
    }
    
    [Test]
    public void T4()
    {
        var sut = new S00278(1702766719);
        Assert.That(sut.FirstBadVersion(2126753390), Is.EqualTo(1702766719));
    }
}