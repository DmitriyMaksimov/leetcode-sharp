using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01816Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01816();
        Assert.That(sut.TruncateSentence("Hello how are you Contestant", 4), Is.EqualTo("Hello how are you"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01816();
        Assert.That(sut.TruncateSentence("What is the solution to this problem", 4), Is.EqualTo("What is the solution"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01816();
        Assert.That(sut.TruncateSentence("chopper is not a tanuki", 5), Is.EqualTo("chopper is not a tanuki"));
    }
}