using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01793Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01793();
        sut.MaximumScore(new[] {1, 4, 3, 7, 4, 5}, 3).Should().Be(15);
    }

    [Test]
    public void T2()
    {
        var sut = new S01793();
        sut.MaximumScore(new[] {5, 5, 4, 5, 4, 1, 1, 1}, 0).Should().Be(20);
    }
}