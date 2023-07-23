using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00859Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00859();
        sut.BuddyStrings("ab", "ba").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00859();
        sut.BuddyStrings("ab", "ab").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00859();
        sut.BuddyStrings("aa", "aa").Should().BeTrue();
    }
}