using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01871))]
public class S01871Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01871();
        Assert.That(sut.CanReach("011010", 2, 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01871();
        Assert.That(sut.CanReach("01101110", 2, 3), Is.False);
    }
}