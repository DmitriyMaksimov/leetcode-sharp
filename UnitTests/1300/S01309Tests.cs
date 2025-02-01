using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01309Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01309();
        Assert.That(sut.FreqAlphabets("10#11#12"), Is.EqualTo("jkab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01309();
        Assert.That(sut.FreqAlphabets("1326#"), Is.EqualTo("acz"));
    }
}