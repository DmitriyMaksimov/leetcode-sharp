using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01037Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01037();
        Assert.That(sut.IsBoomerang([[1, 1], [2, 3], [3, 2]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01037();
        Assert.That(sut.IsBoomerang([[1, 1], [2, 2], [3, 3]]), Is.False);
    }
}
