using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02185Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02185();
        sut.PrefixCount(new[] {"pay", "attention", "practice", "attend"}, "at").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02185();
        sut.PrefixCount(new[] {"leetcode", "win", "loops", "success"}, "code").Should().Be(0);
    }
}