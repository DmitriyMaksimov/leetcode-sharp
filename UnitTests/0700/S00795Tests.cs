using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00795Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00795();
        sut.NumSubarrayBoundedMax([2, 1, 4, 3], 2, 3).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00795();
        sut.NumSubarrayBoundedMax([2, 9, 2, 5, 6], 2, 8).Should().Be(7);
    }
}
