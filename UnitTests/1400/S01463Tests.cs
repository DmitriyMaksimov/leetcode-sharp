using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01463Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01463();
        sut.CherryPickup([[3, 1, 1], [2, 5, 1], [1, 5, 5], [2, 1, 1]]).Should().Be(24);
    }

    [Test]
    public void T2()
    {
        var sut = new S01463();
        sut.CherryPickup([[1, 0, 0, 0, 0, 0, 1], [2, 0, 0, 0, 0, 3, 0], [2, 0, 9, 0, 0, 0, 0], [0, 3, 0, 5, 4, 0, 0], [1, 0, 2, 3, 0, 0, 6]]).Should().Be(28);
    }
}