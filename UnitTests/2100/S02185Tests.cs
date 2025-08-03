using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02185Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02185();
        Assert.That(sut.PrefixCount(["pay", "attention", "practice", "attend"], "at"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02185();
        Assert.That(sut.PrefixCount(["leetcode", "win", "loops", "success"], "code"), Is.EqualTo(0));
    }
}