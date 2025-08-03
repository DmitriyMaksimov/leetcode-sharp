using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00137Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00137();
        Assert.That(sut.SingleNumber([2, 2, 3, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00137();
        Assert.That(sut.SingleNumber([0, 1, 0, 1, 0, 1, 99]), Is.EqualTo(99));
    }
}