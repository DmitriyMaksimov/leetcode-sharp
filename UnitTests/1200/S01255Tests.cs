using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01255Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01255();
        sut.MaxScoreWords(
            new[] {"dog", "cat", "dad", "good"},
            new[] {'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'},
            new[] {1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}).Should().Be(23);
    }

    [Test]
    public void T2()
    {
        var sut = new S01255();
        sut.MaxScoreWords(
            new[] {"xxxz", "ax", "bx", "cx"},
            new[] {'z', 'a', 'b', 'c', 'x', 'x', 'x'},
            new[] {4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10}).Should().Be(27);
    }

    [Test]
    public void T3()
    {
        var sut = new S01255();
        sut.MaxScoreWords(
            new[] {"leetcode"},
            new[] {'l', 'e', 't', 'c', 'o', 'd'},
            new[] {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0}).Should().Be(0);
    }
}