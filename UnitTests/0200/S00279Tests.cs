using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00279Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00279();
        sut.NumSquares(12).Should().Be(3);
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00279();
        sut.NumSquares(13).Should().Be(2);
    }
}