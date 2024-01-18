using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01641Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01641();
        sut.CountVowelStrings(1).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01641();
        sut.CountVowelStrings(2).Should().Be(15);
    }

    [Test]
    public void T3()
    {
        var sut = new S01641();
        sut.CountVowelStrings(33).Should().Be(66045);
    }
}