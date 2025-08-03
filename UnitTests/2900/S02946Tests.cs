using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02946Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02946();
        Assert.That(sut.AreSimilar([[1, 2, 1, 2], [5, 5, 5, 5], [6, 3, 6, 3]], 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02946();
        Assert.That(sut.AreSimilar([[2, 2], [2, 2]], 3), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02946();
        Assert.That(sut.AreSimilar([[1, 2]], 1), Is.False);
    }
}
