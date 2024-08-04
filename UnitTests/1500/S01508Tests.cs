using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01508Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01508();
        sut.RangeSum([1, 2, 3, 4], 4, 1, 5).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S01508();
        sut.RangeSum([1, 2, 3, 4], 4, 3, 4).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01508();
        sut.RangeSum([1, 2, 3, 4], 4, 1, 10).Should().Be(50);
    }
}
