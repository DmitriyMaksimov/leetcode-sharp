using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03614))]
public class S03614Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03614();
        Assert.That(sut.ProcessStr("a#b%*", 1), Is.EqualTo('a'));
    }

    [Test]
    public void T2()
    {
        var sut = new S03614();
        Assert.That(sut.ProcessStr("cd%#*#", 3), Is.EqualTo('d'));
    }

    [Test]
    public void T3()
    {
        var sut = new S03614();
        Assert.That(sut.ProcessStr("z*#", 0), Is.EqualTo('.'));
    }
}