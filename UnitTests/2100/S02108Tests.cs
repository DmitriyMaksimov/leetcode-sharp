using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02108Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02108();
        Assert.That(sut.FirstPalindrome(new[] {"abc", "car", "ada", "racecar", "cool"}), Is.EqualTo("ada"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02108();
        Assert.That(sut.FirstPalindrome(new[] {"notapalindrome", "racecar"}), Is.EqualTo("racecar"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02108();
        Assert.That(sut.FirstPalindrome(new[] {"def", "ghi"}), Is.EqualTo(""));
    }
}