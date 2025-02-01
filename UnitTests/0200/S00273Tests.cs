using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00273Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00273();
        Assert.That(sut.NumberToWords(123), Is.EqualTo("One Hundred Twenty Three"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00273();
        Assert.That(sut.NumberToWords(12345), Is.EqualTo("Twelve Thousand Three Hundred Forty Five"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00273();
        Assert.That(sut.NumberToWords(1234567), Is.EqualTo("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"));
    }
}
