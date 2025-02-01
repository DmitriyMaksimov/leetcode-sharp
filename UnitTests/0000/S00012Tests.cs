using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00012Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(3), Is.EqualTo("III"));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(58), Is.EqualTo("LVIII"));
    }   
    
    [Test]
    public void Test3()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(1994), Is.EqualTo("MCMXCIV"));
    }

    [Test]
    public void Test4()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(60), Is.EqualTo("LX"));
    }

    [Test]
    public void Test5()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(70), Is.EqualTo("LXX"));
    }

    [Test]
    public void Test6()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(80), Is.EqualTo("LXXX"));
    }

    [Test]
    public void Test7()
    {
        var sut = new S00012();
        Assert.That(sut.IntToRoman(600), Is.EqualTo("DC"));
    }
}