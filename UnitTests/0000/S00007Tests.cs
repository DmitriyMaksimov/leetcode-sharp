using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00007Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00007();
        Assert.That(sut.Reverse(123), Is.EqualTo(321));
    }

    [Test]
    public void T2()
    {
        var sut = new S00007();
        Assert.That(sut.Reverse(-123), Is.EqualTo(-321));
    }

    [Test]
    public void T3()
    {
        var sut = new S00007();
        Assert.That(sut.Reverse(120), Is.EqualTo(21));
    }
}
