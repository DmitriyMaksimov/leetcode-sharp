using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01897Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01897();
        Assert.That(sut.MakeEqual(new[] {"abc", "aabc", "bc"}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01897();
        Assert.That(sut.MakeEqual(new[] {"ab", "a"}), Is.False);
    }
}
