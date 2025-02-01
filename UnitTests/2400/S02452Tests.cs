using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02452Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02452();
        Assert.That(sut.TwoEditWords(["word", "note", "ants", "wood"], ["wood", "joke", "moat"]), Is.EqualTo((string[]) ["word", "note", "wood"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02452();
        Assert.That(sut.TwoEditWords(["yes"], ["not"]), Is.Empty);
    }
}
