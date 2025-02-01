using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02452Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02452();
        sut.TwoEditWords(["word", "note", "ants", "wood"], ["wood", "joke", "moat"]).Should().Equal("word", "note", "wood");
    }

    [Test]
    public void T2()
    {
        var sut = new S02452();
        Assert.That(sut.TwoEditWords(["yes"], ["not"]), Is.Empty);
    }
}
