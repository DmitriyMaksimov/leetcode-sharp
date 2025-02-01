using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02684Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02684();
        Assert.That(sut.MaxMoves([[2, 4, 3, 5], [5, 4, 9, 3], [3, 4, 2, 11], [10, 9, 13, 15]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02684();
        Assert.That(sut.MaxMoves([[3, 2, 4], [2, 1, 9], [1, 1, 7]]), Is.EqualTo(0));
    }
}
