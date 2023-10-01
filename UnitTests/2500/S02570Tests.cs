using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02570Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02570();
        sut.MergeArrays(
            new[] {new[] {1, 2}, new[] {2, 3}, new[] {4, 5}},
            new[] {new[] {1, 4}, new[] {3, 2}, new[] {4, 1}}
        ).Should().BeEquivalentTo(new[] {new[] {1, 6}, new[] {2, 3}, new[] {3, 2}, new[] {4, 6}});
    }

    [Test]
    public void T2()
    {
        var sut = new S02570();
        sut.MergeArrays(
            new[] {new[] {2, 4}, new[] {3, 6}, new[] {5, 5}},
            new[] {new[] {1, 3}, new[] {4, 3}}
        ).Should().BeEquivalentTo(new[] {new[] {1, 3}, new[] {2, 4}, new[] {3, 6}, new[] {4, 3}, new[] {5, 5}});
    }
}