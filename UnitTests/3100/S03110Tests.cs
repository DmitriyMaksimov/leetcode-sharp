using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03110();
        Assert.That(sut.ScoreOfString("hello"), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S03110();
        Assert.That(sut.ScoreOfString("zaz"), Is.EqualTo(50));
    }
}