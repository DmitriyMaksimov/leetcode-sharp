using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00962Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00962();
        Assert.That(sut.MaxWidthRamp([6, 0, 8, 2, 1, 5]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00962();
        Assert.That(sut.MaxWidthRamp([9, 8, 1, 0, 1, 9, 4, 0, 4, 1]), Is.EqualTo(7));
    }
}
