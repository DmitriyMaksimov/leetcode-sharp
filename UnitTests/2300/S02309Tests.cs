using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02309Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02309();
        Assert.That(sut.GreatestLetter("lEeTcOdE"), Is.EqualTo("E"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02309();
        Assert.That(sut.GreatestLetter("arRAzFif"), Is.EqualTo("R"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02309();
        Assert.That(sut.GreatestLetter("AbCdEfGhIjK"), Is.EqualTo(""));
    }
}