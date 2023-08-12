using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00076Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00076();
        sut.MinWindow("ADOBECODEBANC", "ABC").Should().Be("BANC");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00076();
        sut.MinWindow("a", "a").Should().Be("a");
    }

    [Test]
    public void T3()
    {
        var sut = new S00076();
        sut.MinWindow("a", "aa").Should().Be("");
    }

}