using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01927))]
public class S01927Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01927();
        Assert.That(sut.SumGame("5023"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01927();
        Assert.That(sut.SumGame("25??"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01927();
        Assert.That(sut.SumGame("?3295???"), Is.False);
    }
}