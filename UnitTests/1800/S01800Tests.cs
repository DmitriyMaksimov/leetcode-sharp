using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01800Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01800();
        Assert.That(sut.MaxAscendingSum([10, 20, 30, 5, 10, 50]), Is.EqualTo(65));
    }

    [Test]
    public void T2()
    {
        var sut = new S01800();
        Assert.That(sut.MaxAscendingSum([10, 20, 30, 40, 50]), Is.EqualTo(150));
    }

    [Test]
    public void T3()
    {
        var sut = new S01800();
        Assert.That(sut.MaxAscendingSum([12, 17, 15, 13, 10, 11, 12]), Is.EqualTo(33));
    }
}