using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00713Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00713();
        sut.NumSubarrayProductLessThanK([10, 5, 2, 6], 100).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S00713();
        sut.NumSubarrayProductLessThanK([1, 2, 3], 0).Should().Be(0);
    }
}