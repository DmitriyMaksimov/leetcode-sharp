using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00827Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00827();
        sut.LargestIsland([[1, 0], [0, 1]]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00827();
        sut.LargestIsland([[1, 1], [1, 0]]).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00827();
        sut.LargestIsland([[1, 1], [1, 1]]).Should().Be(4);
    }
}
