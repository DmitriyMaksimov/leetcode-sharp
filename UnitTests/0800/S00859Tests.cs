using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00859Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00859();
        Assert.That(sut.BuddyStrings("ab", "ba"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00859();
        Assert.That(sut.BuddyStrings("ab", "ab"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00859();
        Assert.That(sut.BuddyStrings("aa", "aa"), Is.True);
    }
}
