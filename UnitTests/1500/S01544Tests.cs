using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01544Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01544();
        Assert.That(sut.MakeGood("leEeetcode"), Is.EqualTo("leetcode"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01544();
        Assert.That(sut.MakeGood("abBAcC"), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S01544();
        Assert.That(sut.MakeGood("s"), Is.EqualTo("s"));
    }
}