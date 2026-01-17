using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03047))]
public class S03047Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03047();
        Assert.That(sut.LargestSquareArea([[1, 1], [3, 3], [3, 1]], [[2, 2], [4, 4], [4, 2]]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03047();
        Assert.That(sut.LargestSquareArea([[1, 1], [2, 2], [3, 1]], [[3, 3], [4, 4], [6, 6]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03047();
        Assert.That(sut.LargestSquareArea([[1, 1], [1, 3], [1, 5]], [[5, 5], [5, 7], [5, 9]]), Is.EqualTo(4));
    }

    [Test]
    public void T4()
    {
        var sut = new S03047();
        Assert.That(sut.LargestSquareArea([[1, 1], [2, 2], [1, 2]], [[3, 3], [4, 4], [3, 4]]), Is.EqualTo(1));
    }
}