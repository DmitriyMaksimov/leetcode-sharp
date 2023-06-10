using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01221Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01221();
        sut.BalancedStringSplit("RLRRLLRLRL").Should().Be(4);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01221();
        sut.BalancedStringSplit("RLRRRLLRLL").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01221();
        sut.BalancedStringSplit("LLLLRRRR").Should().Be(1);
    }
}