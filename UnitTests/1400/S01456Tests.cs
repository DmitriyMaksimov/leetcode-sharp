using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01456Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01456();
        sut.MaxVowels("abciiidef", 3).Should().Be(3);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01456();
        sut.MaxVowels("aeiou", 2).Should().Be(2);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01456();
        sut.MaxVowels("leetcode", 3).Should().Be(2);
    }
}