using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01497Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01497();
        sut.CanArrange([1, 2, 3, 4, 5, 10, 6, 7, 8, 9], 5).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01497();
        sut.CanArrange([1, 2, 3, 4, 5, 6], 7).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01497();
        sut.CanArrange([1, 2, 3, 4, 5, 6], 10).Should().BeFalse();
    }
}
