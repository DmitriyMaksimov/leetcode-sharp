using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01312Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01312();
        Assert.That(sut.MinInsertions("zzazz"), Is.EqualTo(0));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01312();
        Assert.That(sut.MinInsertions("mbadm"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01312();
        Assert.That(sut.MinInsertions("leetcode"), Is.EqualTo(5));
    }
}