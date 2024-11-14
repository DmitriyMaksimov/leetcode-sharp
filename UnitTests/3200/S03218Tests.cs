using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03218Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03218();
        sut.MinimumCost(3, 2, [1, 3], [5]).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S03218();
        sut.MinimumCost(2, 2, [7], [4]).Should().Be(15);
    }
}
