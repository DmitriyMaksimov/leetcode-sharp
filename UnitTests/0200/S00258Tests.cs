using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00258Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00258();
        Assert.That(sut.AddDigits(38), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00258();
        Assert.That(sut.AddDigits(0), Is.EqualTo(0));
    }
}