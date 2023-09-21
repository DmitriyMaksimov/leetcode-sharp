using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02309Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02309();
        sut.GreatestLetter("lEeTcOdE").Should().Be("E");
    }

    [Test]
    public void T2()
    {
        var sut = new S02309();
        sut.GreatestLetter("arRAzFif").Should().Be("R");
    }

    [Test]
    public void T3()
    {
        var sut = new S02309();
        sut.GreatestLetter("AbCdEfGhIjK").Should().Be("");
    }
}