using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00345Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00345();
        sut.ReverseVowels("hello").Should().Be("holle");
    }

    [Test]
    public void T2()
    {
        var sut = new S00345();
        sut.ReverseVowels("leetcode").Should().Be("leotcede");
    }
}