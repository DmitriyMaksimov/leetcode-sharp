using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00205Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00205();
        Assert.That(sut.IsIsomorphic("egg", "add"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00205();
        Assert.That(sut.IsIsomorphic("foo", "bar"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00205();
        Assert.That(sut.IsIsomorphic("paper", "title"), Is.True);
    }

}
