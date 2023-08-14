using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00205Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00205();
        sut.IsIsomorphic("egg", "add").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00205();
        sut.IsIsomorphic("foo", "bar").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00205();
        sut.IsIsomorphic("paper", "title").Should().BeTrue();
    }

}