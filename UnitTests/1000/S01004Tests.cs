using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01004Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01004();
        sut.LongestOnes(new[] {1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0}, 2).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01004();
        sut.LongestOnes(new[] {0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1}, 3).Should().Be(10);
    }
}