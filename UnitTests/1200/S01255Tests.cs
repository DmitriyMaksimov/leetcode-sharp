using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01255Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01255();
        Assert.That(sut.MaxScoreWords(
            ["dog", "cat", "dad", "good"],
            ['a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'],
            [1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]), Is.EqualTo(23));
    }

    [Test]
    public void T2()
    {
        var sut = new S01255();
        Assert.That(sut.MaxScoreWords(
            ["xxxz", "ax", "bx", "cx"],
            ['z', 'a', 'b', 'c', 'x', 'x', 'x'],
            [4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10]), Is.EqualTo(27));
    }

    [Test]
    public void T3()
    {
        var sut = new S01255();
        Assert.That(sut.MaxScoreWords(
            ["leetcode"],
            ['l', 'e', 't', 'c', 'o', 'd'],
            [0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0]), Is.EqualTo(0));
    }
}