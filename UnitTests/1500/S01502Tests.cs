using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01502Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01502();
        Assert.That(sut.CanMakeArithmeticProgression(new[] {3, 5, 1}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01502();
        Assert.That(sut.CanMakeArithmeticProgression(new[] {1, 2, 4}), Is.False);
    }
}
