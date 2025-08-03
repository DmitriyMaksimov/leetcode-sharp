using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01460Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01460();
        Assert.That(sut.CanBeEqual([1, 2, 3, 4], [2, 4, 1, 3]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01460();
        Assert.That(sut.CanBeEqual([7], [7]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01460();
        Assert.That(sut.CanBeEqual([3, 7, 9], [3, 7, 11]), Is.False);
    }
}
