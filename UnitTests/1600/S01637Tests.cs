using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01637Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01637();
        sut.MaxWidthOfVerticalArea(new[] {new[] {8, 7}, new[] {9, 9}, new[] {7, 4}, new[] {9, 7}}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01637();
        sut.MaxWidthOfVerticalArea(new[]
            {new[] {3, 1}, new[] {9, 0}, new[] {1, 0}, new[] {1, 4}, new[] {5, 3}, new[] {8, 8}}).Should().Be(3);
    }
}