using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01816Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01816();
        sut.TruncateSentence("Hello how are you Contestant", 4).Should().Be("Hello how are you");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01816();
        sut.TruncateSentence("What is the solution to this problem", 4).Should().Be("What is the solution");
    }

    [Test]
    public void T3()
    {
        var sut = new S01816();
        sut.TruncateSentence("chopper is not a tanuki", 5).Should().Be("chopper is not a tanuki");
    }
}