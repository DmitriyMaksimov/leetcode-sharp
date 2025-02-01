using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00840Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00840();
        Assert.That(sut.NumMagicSquaresInside([[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00840();
        Assert.That(sut.NumMagicSquaresInside([[8]]), Is.EqualTo(0));
    }
}
