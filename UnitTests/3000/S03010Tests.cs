using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03010Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03010();
        sut.MinimumCost([1, 2, 3, 12]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S03010();
        sut.MinimumCost([5, 4, 3]).Should().Be(12);
    }

    [Test]
    public void T3()
    {
        var sut = new S03010();
        sut.MinimumCost([10, 3, 1, 1]).Should().Be(12);
    }

    [Test]
    public void T4()
    {
        var sut = new S03010();
        sut.MinimumCost([1, 6, 1, 5]).Should().Be(7);
    }
}