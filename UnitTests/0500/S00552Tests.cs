using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00552Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00552();
        Assert.That(sut.CheckRecord(2), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S00552();
        Assert.That(sut.CheckRecord(1), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00552();
        Assert.That(sut.CheckRecord(10101), Is.EqualTo(183236316));
    }
}