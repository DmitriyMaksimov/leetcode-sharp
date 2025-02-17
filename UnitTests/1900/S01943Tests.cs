using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01943Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01943();
        Assert.That(sut.SplitPainting([[1, 4, 5], [4, 7, 7], [1, 7, 9]]), Is.EqualTo([(int[]) [1, 4, 14], [4, 7, 16]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01943();
        Assert.That(sut.SplitPainting([[1, 7, 9], [6, 8, 15], [8, 10, 7]]), Is.EqualTo([(int[]) [1, 6, 9], [6, 7, 24], [7, 8, 15], [8, 10, 7]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01943();
        Assert.That(sut.SplitPainting([[1, 4, 5], [1, 4, 7], [4, 7, 1], [4, 7, 11]]), Is.EqualTo([(int[]) [1, 4, 12], [4, 7, 12]]));
    }
}
