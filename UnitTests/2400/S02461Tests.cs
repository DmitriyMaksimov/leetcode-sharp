using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02461Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02461();
        Assert.That(sut.MaximumSubarraySum([1, 5, 4, 2, 9, 9, 9], 3), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02461();
        Assert.That(sut.MaximumSubarraySum([4, 4, 4], 3), Is.EqualTo(0));
    }
}
