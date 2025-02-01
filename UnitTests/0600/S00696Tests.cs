using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00696Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00696();
        Assert.That(sut.CountBinarySubstrings("00110011"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00696();
        Assert.That(sut.CountBinarySubstrings("10101"), Is.EqualTo(4));
    }
}