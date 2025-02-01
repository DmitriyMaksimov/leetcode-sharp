using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01400Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01400();
        Assert.That(sut.CanConstruct("annabelle", 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01400();
        Assert.That(sut.CanConstruct("leetcode", 3), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01400();
        Assert.That(sut.CanConstruct("true", 4), Is.True);
    }
}
