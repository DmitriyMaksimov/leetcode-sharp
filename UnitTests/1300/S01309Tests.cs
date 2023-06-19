using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01309Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01309();
        sut.FreqAlphabets("10#11#12").Should().Be("jkab");
    }

    [Test]
    public void T2()
    {
        var sut = new S01309();
        sut.FreqAlphabets("1326#").Should().Be("acz");
    }
}