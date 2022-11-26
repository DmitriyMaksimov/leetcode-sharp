using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00907UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00907();
        sut.SumSubarrayMins(new[] {3, 1, 2, 4}).Should().Be(17);
    }
}