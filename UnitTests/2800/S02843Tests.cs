using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02843Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02843();
        Assert.That(sut.CountSymmetricIntegers(1, 100), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02843();
        Assert.That(sut.CountSymmetricIntegers(1200, 1230), Is.EqualTo(4));
    }
}