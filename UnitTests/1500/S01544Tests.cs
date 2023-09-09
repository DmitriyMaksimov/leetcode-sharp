using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01544Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01544();
        sut.MakeGood("leEeetcode").Should().Be("leetcode");
    }

    [Test]
    public void T2()
    {
        var sut = new S01544();
        sut.MakeGood("abBAcC").Should().Be("");
    }

    [Test]
    public void T3()
    {
        var sut = new S01544();
        sut.MakeGood("s").Should().Be("s");
    }
}