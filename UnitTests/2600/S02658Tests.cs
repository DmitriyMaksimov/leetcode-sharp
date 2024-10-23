using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02658Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02658();
        sut.FindMaxFish([[0, 2, 1, 0], [4, 0, 0, 3], [1, 0, 0, 4], [0, 3, 2, 0]]).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S02658();
        sut.FindMaxFish([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 1]]).Should().Be(1);
    }
}
