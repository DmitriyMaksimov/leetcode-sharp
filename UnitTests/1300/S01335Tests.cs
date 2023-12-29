using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01335Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01335();
        sut.MinDifficulty(new[] {6, 5, 4, 3, 2, 1}, 2).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S01335();
        sut.MinDifficulty(new[] {9, 9, 9}, 4).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01335();
        sut.MinDifficulty(new[] {1, 1, 1}, 3).Should().Be(3);
    }
}