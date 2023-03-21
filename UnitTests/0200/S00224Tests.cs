
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00224UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00224();
        sut.Calculate("1+1").Should().Be(2);
    }    
    
    [Test]
    public void Test2()
    {
        var sut = new S00224();
        sut.Calculate(" 2-1 + 2 ").Should().Be(3);
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S00224();
        sut.Calculate("(1+(4+5+2)-3)+(6+8)").Should().Be(23);
    }    
}