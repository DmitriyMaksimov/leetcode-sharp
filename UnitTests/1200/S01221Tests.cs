using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01221Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01221();
        Assert.That(sut.BalancedStringSplit("RLRRLLRLRL"), Is.EqualTo(4));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01221();
        Assert.That(sut.BalancedStringSplit("RLRRRLLRLL"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01221();
        Assert.That(sut.BalancedStringSplit("LLLLRRRR"), Is.EqualTo(1));
    }
}