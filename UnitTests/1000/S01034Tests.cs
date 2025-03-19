using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01034Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01034();
        Assert.That(sut.ColorBorder([[1, 1], [1, 2]], 0, 0, 3), Is.EqualTo([(int[]) [3, 3], [3, 2]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01034();
        Assert.That(sut.ColorBorder([[1, 2, 2], [2, 3, 2]], 0, 1, 3), Is.EqualTo([(int[]) [1, 3, 3], [2, 3, 3]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01034();
        Assert.That(sut.ColorBorder([[1, 1, 1], [1, 1, 1], [1, 1, 1]], 1, 1, 2), Is.EqualTo([(int[]) [2, 2, 2], [2, 1, 2], [2, 2, 2]]));
    }
}
