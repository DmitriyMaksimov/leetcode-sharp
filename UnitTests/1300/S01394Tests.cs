using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01394Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01394();
        Assert.That(sut.FindLucky([2, 2, 3, 4]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01394();
        Assert.That(sut.FindLucky([1, 2, 2, 3, 3, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01394();
        Assert.That(sut.FindLucky([2, 2, 2, 3, 3]), Is.EqualTo(-1));
    }
}