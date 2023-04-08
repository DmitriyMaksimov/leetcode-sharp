using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00028Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00028();
        sut.StrStr("sadbutsad", "sad").Should().Be(0);
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00028();
        sut.StrStr("leetcode", "leeto").Should().Be(-1);
    }
}