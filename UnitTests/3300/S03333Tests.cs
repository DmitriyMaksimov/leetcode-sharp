using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03333))]
public class S03333Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03333();
        Assert.That(sut.PossibleStringCount("aabbccdd", 7), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03333();
        Assert.That(sut.PossibleStringCount("aabbccdd", 8), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03333();
        Assert.That(sut.PossibleStringCount("aaabbb", 3), Is.EqualTo(8));
    }
}