using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01007Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01007();
        sut.MinDominoRotations([2, 1, 2, 4, 2, 2], [5, 2, 6, 2, 3, 2]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01007();
        sut.MinDominoRotations([3, 5, 1, 2, 3], [3, 6, 3, 3, 4]).Should().Be(-1);
    }
}
