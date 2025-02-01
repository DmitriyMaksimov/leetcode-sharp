using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00476Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00476();
        Assert.That(sut.FindComplement(5), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00476();
        Assert.That(sut.FindComplement(1), Is.EqualTo(0));
    }
}