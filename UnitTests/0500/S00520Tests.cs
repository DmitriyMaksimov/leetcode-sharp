using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00520Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00520();
        Assert.That(sut.DetectCapitalUse("USA"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00520();
        Assert.That(sut.DetectCapitalUse("FlaG"), Is.False);
    }    
}
