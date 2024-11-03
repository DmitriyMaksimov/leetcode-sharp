using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02110();
        sut.GetDescentPeriods([3, 2, 1, 4]).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S02110();
        sut.GetDescentPeriods([8, 6, 7, 7]).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02110();
        sut.GetDescentPeriods([1]).Should().Be(1);
    }
}
