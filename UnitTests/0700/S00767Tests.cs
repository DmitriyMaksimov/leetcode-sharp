using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00767Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00767();
        Assert.That(sut.ReorganizeString("aab"), Is.EqualTo("aba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00767();
        Assert.That(sut.ReorganizeString("aaab"), Is.EqualTo(""));
    }
}