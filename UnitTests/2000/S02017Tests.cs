using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02017Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02017();
        sut.GridGame([[2, 5, 4], [1, 5, 1]]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02017();
        sut.GridGame([[3, 3, 1], [8, 5, 2]]).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02017();
        sut.GridGame([[1, 3, 1, 15], [1, 3, 3, 1]]).Should().Be(7);
    }
}
