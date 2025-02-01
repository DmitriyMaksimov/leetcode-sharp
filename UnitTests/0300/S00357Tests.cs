using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00357Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00357();
        Assert.That(sut.CountNumbersWithUniqueDigits(2), Is.EqualTo(91));
    }

    [Test]
    public void T2()
    {
        var sut = new S00357();
        Assert.That(sut.CountNumbersWithUniqueDigits(0), Is.EqualTo(1));
    }
}
