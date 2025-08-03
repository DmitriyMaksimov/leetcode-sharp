using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00136Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00136();
        Assert.That(sut.SingleNumber([2, 2, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00136();
        Assert.That(sut.SingleNumber([4, 1, 2, 1, 2]), Is.EqualTo(4));
    }
}