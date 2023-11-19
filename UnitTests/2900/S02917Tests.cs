using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02917Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02917();
        sut.FindKOr(new[] {7, 12, 9, 8, 9, 15}, 4).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02917();
        sut.FindKOr(new[] {2, 12, 1, 11, 4, 5}, 6).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02917();
        sut.FindKOr(new[] {10, 8, 5, 9, 11, 6, 8}, 1).Should().Be(15);
    }
}