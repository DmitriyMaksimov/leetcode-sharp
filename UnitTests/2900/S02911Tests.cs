using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02911))]
public class S02911Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02911();
        Assert.That(sut.MinimumChanges("abcac", 2), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02911();
        Assert.That(sut.MinimumChanges("abcdef", 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02911();
        Assert.That(sut.MinimumChanges("aabbaa", 3), Is.Zero);
    }
}