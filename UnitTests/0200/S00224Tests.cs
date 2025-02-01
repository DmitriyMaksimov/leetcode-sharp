
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00224Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00224();
        Assert.That(sut.Calculate("1+1"), Is.EqualTo(2));
    }    
    
    [Test]
    public void Test2()
    {
        var sut = new S00224();
        Assert.That(sut.Calculate(" 2-1 + 2 "), Is.EqualTo(3));
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S00224();
        Assert.That(sut.Calculate("(1+(4+5+2)-3)+(6+8)"), Is.EqualTo(23));
    }    
}