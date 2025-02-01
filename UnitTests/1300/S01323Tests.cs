using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01323Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01323();
        Assert.That(sut.Maximum69Number(9669), Is.EqualTo(9969));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01323();
        Assert.That(sut.Maximum69Number(9996), Is.EqualTo(9999));
    }

    [Test]
    public void T3()
    {
        var sut = new S01323();
        Assert.That(sut.Maximum69Number(9999), Is.EqualTo(9999));
    }
}