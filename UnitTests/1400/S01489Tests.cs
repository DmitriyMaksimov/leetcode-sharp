using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01489Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01489();
        sut.FindCriticalAndPseudoCriticalEdges(5,
            new[]
            {
                new[] {0, 1, 1}, new[] {1, 2, 1}, new[] {2, 3, 2}, new[] {0, 3, 2}, new[] {0, 4, 3}, new[] {3, 4, 3},
                new[] {1, 4, 6}
            }).Should().BeEquivalentTo(new[] {new []{0, 1}, new[] {2, 3, 4, 5}});
    }

    [Test]
    public void T2()
    {
        var sut = new S01489();
        sut.FindCriticalAndPseudoCriticalEdges(4,
            new[]
            {
                new[] {0, 1, 1}, new[] {1, 2, 1}, new[] {2, 3, 1}, new[] {0, 3, 1}
            }).Should().BeEquivalentTo(new[] {Array.Empty<int>(), new[] {0, 1, 2, 3}});
    }
}