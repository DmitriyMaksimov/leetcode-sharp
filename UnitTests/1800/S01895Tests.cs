using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01895Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01895();
        Assert.That(sut.LargestMagicSquare([[7, 1, 4, 5, 6], [2, 5, 1, 6, 4], [1, 5, 4, 3, 2], [1, 2, 7, 3, 4]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01895();
        Assert.That(sut.LargestMagicSquare([[5, 1, 3, 1], [9, 3, 3, 1], [1, 3, 3, 8]]), Is.EqualTo(2));
    }
}
