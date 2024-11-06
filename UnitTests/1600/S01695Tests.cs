using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01695Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01695();
        sut.MaximumUniqueSubarray([4, 2, 4, 5, 6]).Should().Be(17);
    }

    [Test]
    public void T2()
    {
        var sut = new S01695();
        sut.MaximumUniqueSubarray([5, 2, 1, 2, 5, 2, 1, 2, 5]).Should().Be(8);
    }
}
