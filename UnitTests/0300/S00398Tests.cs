using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00398Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00398.Solution([1, 2, 3, 3, 3]);
        Assert.That(sut.Pick(3), Is.AnyOf(2, 3, 4)); // It should return either index 2, 3, or 4 randomly. Each index should have equal probability of returning.
        Assert.That(sut.Pick(1), Is.EqualTo(0)); // It should return 0. Since in the array only nums[0] is equal to 1.
        Assert.That(sut.Pick(3), Is.AnyOf(2, 3, 4)); // It should return either index 2, 3, or 4 randomly. Each index should have equal probability of returning.
    }
}
