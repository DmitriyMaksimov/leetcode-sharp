using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02542Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02542();
        sut.MaxScore(new[] {1, 3, 3, 2}, new[] {2, 1, 3, 4}, 3).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S02542();
        sut.MaxScore(new[] {4, 2, 3, 1, 1}, new[] {7, 5, 10, 9, 6}, 1).Should().Be(30);
    }
}