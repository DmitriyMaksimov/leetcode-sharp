using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01037Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01037();
        Assert.That(sut.IsBoomerang(new[] {new[] {1, 1}, new[] {2, 3}, new[] {3, 2}}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01037();
        Assert.That(sut.IsBoomerang(new[] {new[] {1, 1}, new[] {2, 2}, new[] {3, 3}}), Is.False);
    }
}
