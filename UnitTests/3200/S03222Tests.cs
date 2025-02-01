using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03222Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03222();
        Assert.That(sut.LosingPlayer(2, 7), Is.EqualTo("Alice"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03222();
        Assert.That(sut.LosingPlayer(4, 11), Is.EqualTo("Bob"));
    }
}