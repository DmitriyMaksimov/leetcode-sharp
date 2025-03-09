using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02018Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02018();
        Assert.That(sut.PlaceWordInCrossword([['#', ' ', '#'], [' ', ' ', '#'], ['#', 'c', ' ']], "abc"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02018();
        Assert.That(sut.PlaceWordInCrossword([[' ', '#', 'a'], [' ', '#', 'c'], [' ', '#', 'a']], "ac"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02018();
        Assert.That(sut.PlaceWordInCrossword([['#', ' ', '#'], [' ', ' ', '#'], ['#', ' ', 'c']], "ca"), Is.True);
    }
}
