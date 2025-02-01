using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00028Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00028();
        Assert.That(sut.StrStr("sadbutsad", "sad"), Is.EqualTo(0));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00028();
        Assert.That(sut.StrStr("leetcode", "leeto"), Is.EqualTo(-1));
    }
}