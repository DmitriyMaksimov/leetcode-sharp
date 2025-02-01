using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00228Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00228();
        Assert.That(sut.SummaryRanges(new[] {0, 1, 2, 4, 5, 7}), Is.EqualTo((string[]) ["0->2", "4->5", "7"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00228();
        Assert.That(sut.SummaryRanges(new[] {0, 2, 3, 4, 6, 8, 9}), Is.EqualTo((string[]) ["0", "2->4", "6", "8->9"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00228();
        Assert.That(sut.SummaryRanges(new[] {-2147483648, -2147483647, 2147483647}), Is.EqualTo((string[]) ["-2147483648->-2147483647", "2147483647"]));
    }
}
