using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01456Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01456();
        Assert.That(sut.MaxVowels("abciiidef", 3), Is.EqualTo(3));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01456();
        Assert.That(sut.MaxVowels("aeiou", 2), Is.EqualTo(2));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01456();
        Assert.That(sut.MaxVowels("leetcode", 3), Is.EqualTo(2));
    }
}