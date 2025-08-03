using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01886Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01886();
        Assert.That(sut.FindRotation([[0, 1], [1, 0]], [[1, 0], [0, 1]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01886();
        Assert.That(sut.FindRotation([[0, 1], [1, 1]], [[1, 0], [0, 1]]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01886();
        Assert.That(sut.FindRotation([[0, 0, 0], [0, 1, 0], [1, 1, 1]],
            [[1, 1, 1], [0, 1, 0], [0, 0, 0]]), Is.True);
    }
}
