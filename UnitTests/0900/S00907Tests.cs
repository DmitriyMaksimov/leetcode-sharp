using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00907Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00907();
        Assert.That(sut.SumSubarrayMins([3, 1, 2, 4]), Is.EqualTo(17));
    }
}