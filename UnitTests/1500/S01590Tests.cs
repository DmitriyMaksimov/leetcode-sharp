using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01590Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01590();
        sut.MinSubarray([3, 1, 4, 2], 6).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01590();
        sut.MinSubarray([6, 3, 5, 2], 9).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01590();
        sut.MinSubarray([1, 2, 3], 3).Should().Be(0);
    }
}
