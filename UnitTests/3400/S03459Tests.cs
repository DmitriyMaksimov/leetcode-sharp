using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03459))]
public class S03459Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03459();
        Assert.That(
            sut.LenOfVDiagonal([[2, 2, 1, 2, 2], [2, 0, 2, 2, 0], [2, 0, 1, 1, 0], [1, 0, 2, 2, 2], [2, 0, 0, 2, 2]]),
            Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03459();
        Assert.That(
            sut.LenOfVDiagonal([[2, 2, 2, 2, 2], [2, 0, 2, 2, 0], [2, 0, 1, 1, 0], [1, 0, 2, 2, 2], [2, 0, 0, 2, 2]]),
            Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S03459();
        Assert.That(
            sut.LenOfVDiagonal([[1, 2, 2, 2, 2], [2, 2, 2, 2, 0], [2, 0, 0, 0, 0], [0, 0, 2, 2, 2], [2, 0, 0, 2, 0]]),
            Is.EqualTo(5));
    }
}