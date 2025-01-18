using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01368Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01368();
        sut.MinCost([[1, 1, 1, 1], [2, 2, 2, 2], [1, 1, 1, 1], [2, 2, 2, 2]]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01368();
        sut.MinCost([[1, 1, 3], [3, 2, 2], [1, 1, 4]]).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01368();
        sut.MinCost([[1, 2], [4, 3]]).Should().Be(1);
    }
}
