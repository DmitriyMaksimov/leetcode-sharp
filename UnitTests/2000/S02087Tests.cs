using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02087Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02087();
        sut.MinCost([1, 0], [2, 3], [5, 4, 3], [8, 2, 6, 7]).Should().Be(18);
    }

    [Test]
    public void T2()
    {
        var sut = new S02087();
        sut.MinCost([0, 0], [0, 0], [5], [26]).Should().Be(0);
    }
}
