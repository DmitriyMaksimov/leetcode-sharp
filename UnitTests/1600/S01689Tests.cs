using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01689Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01689();
        Assert.That(sut.MinPartitions("32"), Is.EqualTo(3));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01689();
        Assert.That(sut.MinPartitions("82734"), Is.EqualTo(8));
    }

    [Test]
    public void T3()
    {
        var sut = new S01689();
        Assert.That(sut.MinPartitions("27346209830709182346"), Is.EqualTo(9));
    }
}