using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00273Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00273();
        sut.NumberToWords(123).Should().Be("One Hundred Twenty Three");
    }

    [Test]
    public void T2()
    {
        var sut = new S00273();
        sut.NumberToWords(12345).Should().Be("Twelve Thousand Three Hundred Forty Five");
    }

    [Test]
    public void T3()
    {
        var sut = new S00273();
        sut.NumberToWords(1234567).Should().Be("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven");
    }
}
