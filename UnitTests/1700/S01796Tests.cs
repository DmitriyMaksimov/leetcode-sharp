using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01796Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01796();
        sut.SecondHighest("dfa12321afd").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01796();
        sut.SecondHighest("abc1111").Should().Be(-1);
    }
}