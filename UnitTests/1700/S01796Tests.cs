using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01796Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01796();
        Assert.That(sut.SecondHighest("dfa12321afd"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01796();
        Assert.That(sut.SecondHighest("abc1111"), Is.EqualTo(-1));
    }
}