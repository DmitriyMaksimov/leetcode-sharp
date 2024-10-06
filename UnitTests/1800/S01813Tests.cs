using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01813Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01813();
        sut.AreSentencesSimilar("My name is Haley", "My Haley").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01813();
        sut.AreSentencesSimilar("of", "A lot of words").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01813();
        sut.AreSentencesSimilar("Eating right now", "Eating").Should().BeTrue();
    }
}
