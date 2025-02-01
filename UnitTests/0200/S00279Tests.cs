using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00279Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00279();
        Assert.That(sut.NumSquares(12), Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00279();
        Assert.That(sut.NumSquares(13), Is.EqualTo(2));
    }
}