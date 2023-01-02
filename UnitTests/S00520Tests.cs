using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00520Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00520();
        sut.DetectCapitalUse("USA").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00520();
        sut.DetectCapitalUse("FlaG").Should().BeFalse();
    }    
}