using FluentAssertions;
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00012UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00012();
        sut.IntToRoman(3).Should().Be("III");
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00012();
        sut.IntToRoman(58).Should().Be("LVIII");
    }   
    
    [Test]
    public void Test3()
    {
        var sut = new S00012();
        sut.IntToRoman(1994).Should().Be("MCMXCIV");
    }

    [Test]
    public void Test4()
    {
        var sut = new S00012();
        sut.IntToRoman(60).Should().Be("LX");
    }

    [Test]
    public void Test5()
    {
        var sut = new S00012();
        sut.IntToRoman(70).Should().Be("LXX");
    }

    [Test]
    public void Test6()
    {
        var sut = new S00012();
        sut.IntToRoman(80).Should().Be("LXXX");
    }

    [Test]
    public void Test7()
    {
        var sut = new S00012();
        sut.IntToRoman(600).Should().Be("DC");
    }
}