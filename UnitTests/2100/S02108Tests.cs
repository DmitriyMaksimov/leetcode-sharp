using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02108Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02108();
        sut.FirstPalindrome(new[] {"abc", "car", "ada", "racecar", "cool"}).Should().Be("ada");
    }

    [Test]
    public void T2()
    {
        var sut = new S02108();
        sut.FirstPalindrome(new[] {"notapalindrome", "racecar"}).Should().Be("racecar");
    }

    [Test]
    public void T3()
    {
        var sut = new S02108();
        sut.FirstPalindrome(new[] {"def", "ghi"}).Should().Be("");
    }
}