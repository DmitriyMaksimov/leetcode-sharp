using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00238Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00238();
        Assert.That(sut.ProductExceptSelf([1, 2, 3, 4]), Is.EqualTo((int[]) [24, 12, 8, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00238();
        Assert.That(sut.ProductExceptSelf([-1, 1, 0, -3, 3]), Is.EqualTo((int[]) [0, 0, 9, 0, 0]));
    }
}