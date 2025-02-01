using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01668Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01668();
        Assert.That(sut.MaxRepeating("ababc", "ab"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01668();
        Assert.That(sut.MaxRepeating("ababc", "ba"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01668();
        Assert.That(sut.MaxRepeating("ababc", "ac"), Is.EqualTo(0));
    }
}