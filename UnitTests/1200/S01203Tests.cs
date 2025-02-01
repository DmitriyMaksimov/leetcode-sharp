using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01203Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01203();
        Assert.That(sut.SortItems(8, 2, new[] {-1, -1, 1, 0, 0, 1, 0, -1},
            new IList<int>[]
            {
                Array.Empty<int>(), new[] {6}, new[] {5}, new[] {6}, new[] {3, 6},
                Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>()
            }), Is.EqualTo((int[]) [7, 0, 5, 2, 6, 3, 4, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01203();
        Assert.That(sut.SortItems(8, 2, new[] {-1, -1, 1, 0, 0, 1, 0, -1},
            new IList<int>[]
            {
                Array.Empty<int>(), new[] {6}, new[] {5}, new[] {6}, new[] {3}, Array.Empty<int>(),
                new[] {4}, Array.Empty<int>()
            }), Is.Empty);
    }
}