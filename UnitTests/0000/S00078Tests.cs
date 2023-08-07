using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00078Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00078();
        sut.Subsets(new[] {1, 2, 3}).Should().BeEquivalentTo(new[]
        {
            Array.Empty<int>(),
            new[] {1}, new[] {2}, new[] {3},
            new[] {1, 2}, new[] {1, 3}, new[] {2, 3},
            new[] {1, 2, 3}
        });
    }

    [Test]
    public void T2()
    {
        var sut = new S00078();
        sut.Subsets(new[] {0}).Should().BeEquivalentTo(new[] {Array.Empty<int>(), new[] {0}});
    }
}