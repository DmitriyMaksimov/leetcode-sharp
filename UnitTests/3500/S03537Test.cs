using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03537))]
public class S03537Test
{
    [Test]
    public void T1()
    {
        var sut = new S03537();
        Assert.That(sut.SpecialGrid(0), Is.EqualTo([(int[]) [0]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03537();
        Assert.That(sut.SpecialGrid(1), Is.EqualTo([(int[]) [3, 0], [2, 1]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03537();
        Assert.That(sut.SpecialGrid(2), Is.EqualTo([(int[]) [15, 12, 3, 0], [14, 13, 2, 1], [11, 8, 7, 4], [10, 9, 6, 5]]));
    }
}
