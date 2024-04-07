using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03095Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03095();
        sut.MinimumSubarrayLength([1, 2, 3], 2).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03095();
        sut.MinimumSubarrayLength([2, 1, 8], 10).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S03095();
        sut.MinimumSubarrayLength([1, 2], 0).Should().Be(1);
    }
}