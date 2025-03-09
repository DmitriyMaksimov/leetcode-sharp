using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03462Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03462();
        Assert.That(sut.MaxSum([[1, 2], [3, 4]], [1, 2], 2), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03462();
        Assert.That(sut.MaxSum([[5, 3, 7], [8, 2, 6]], [2, 2], 3), Is.EqualTo(21));
    }
}
