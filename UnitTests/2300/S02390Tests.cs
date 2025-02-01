using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02390Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02390();
        Assert.That(sut.RemoveStars("leet**cod*e"), Is.EqualTo("lecoe"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02390();
        Assert.That(sut.RemoveStars("erase*****"), Is.EqualTo(""));
    }
}