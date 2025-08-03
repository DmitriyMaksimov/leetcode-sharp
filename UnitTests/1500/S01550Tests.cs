using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01550Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01550();
        Assert.That(sut.ThreeConsecutiveOdds([2, 6, 4, 1]), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01550();
        Assert.That(sut.ThreeConsecutiveOdds([1, 2, 34, 3, 4, 5, 7, 23, 12]), Is.True);
    }
}
