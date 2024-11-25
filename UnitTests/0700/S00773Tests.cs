using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00773Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00773();
        sut.SlidingPuzzle([[1, 2, 3], [4, 0, 5]]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00773();
        sut.SlidingPuzzle([[1, 2, 3], [5, 4, 0]]).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00773();
        sut.SlidingPuzzle([[4, 1, 2], [5, 0, 3]]).Should().Be(5);
    }
}
