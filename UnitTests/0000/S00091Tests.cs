using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00091Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00091();
        Assert.That(sut.NumDecodings("12"), Is.EqualTo(2));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00091();
        Assert.That(sut.NumDecodings("226"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00091();
        Assert.That(sut.NumDecodings("06"), Is.EqualTo(0));
    }
}