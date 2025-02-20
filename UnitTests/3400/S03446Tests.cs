using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03446Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03446();
        Assert.That(sut.SortMatrix([[1, 7, 3], [9, 8, 2], [4, 5, 6]]), Is.EqualTo([(int[]) [8, 2, 3], [9, 6, 7], [4, 5, 1]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03446();
        Assert.That(sut.SortMatrix([[0, 1], [1, 2]]), Is.EqualTo([(int[]) [2, 1], [1, 0]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03446();
        Assert.That(sut.SortMatrix([[1]]), Is.EqualTo([(int[]) [1]]));
    }
}
