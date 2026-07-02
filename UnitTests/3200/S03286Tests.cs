using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03286))]
public class S03286Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03286();
        Assert.That(sut.FindSafeWalk([[0, 1, 0, 0, 0], [0, 1, 0, 1, 0], [0, 0, 0, 1, 0]], 1), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03286();
        Assert.That(sut.FindSafeWalk([[0, 1, 1, 0, 0, 0], [1, 0, 1, 0, 0, 0], [0, 1, 1, 1, 0, 1], [0, 0, 1, 0, 1, 0]], 3), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03286();
        Assert.That(sut.FindSafeWalk([[1, 1, 1], [1, 0, 1], [1, 1, 1]], 5), Is.True);
    }
}