using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00371Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00371();
        Assert.That(sut.GetSum(1, 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00371();
        Assert.That(sut.GetSum(2, 3), Is.EqualTo(5));
    }
}
