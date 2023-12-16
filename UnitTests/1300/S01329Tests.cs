using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01329Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01329();
        sut.DiagonalSort(new[] {new[] {3, 3, 1, 1}, new[] {2, 2, 1, 2}, new[] {1, 1, 1, 2}}).Should()
            .BeEquivalentTo(new[]{new[] {1, 1, 1, 1}, new[] {1, 2, 2, 2}, new[] {1, 2, 3, 3}});
    }

    [Test]
    public void T2()
    {
        var sut = new S01329();
        sut.DiagonalSort(new[]
            {
                new[] {11, 25, 66, 1, 69, 7}, new[] {23, 55, 17, 45, 15, 52}, new[] {75, 31, 36, 44, 58, 8},
                new[] {22, 27, 33, 25, 68, 4}, new[] {84, 28, 14, 11, 5, 50}
            }).Should()
            .BeEquivalentTo(new[]
            {
                new[] {5, 17, 4, 1, 52, 7}, new[] {11, 11, 25, 45, 8, 69}, new[] {14, 23, 25, 44, 58, 15},
                new[] {22, 27, 31, 36, 50, 66}, new[] {84, 28, 75, 33, 55, 68}
            });
    }
}