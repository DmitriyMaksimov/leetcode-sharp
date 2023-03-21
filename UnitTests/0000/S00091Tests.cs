using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00091Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00091();
        sut.NumDecodings("12").Should().Be(2);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00091();
        sut.NumDecodings("226").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00091();
        sut.NumDecodings("06").Should().Be(0);
    }
}