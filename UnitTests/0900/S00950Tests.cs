using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00950Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00950();
        Assert.That(sut.DeckRevealedIncreasing([17, 13, 11, 2, 3, 5, 7]), Is.EqualTo((int[]) [2, 13, 3, 11, 5, 17, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00950();
        Assert.That(sut.DeckRevealedIncreasing([1, 1000]), Is.EqualTo((int[]) [1, 1000]));
    }
}