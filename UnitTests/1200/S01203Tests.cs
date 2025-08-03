using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01203Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01203();
        Assert.That(sut.SortItems(8, 2, [-1, -1, 1, 0, 0, 1, 0, -1],
        [
            Array.Empty<int>(), [6], [5], [6], [3, 6],
                Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>()
        ]), Is.EqualTo((int[]) [7, 0, 5, 2, 6, 3, 4, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01203();
        Assert.That(sut.SortItems(8, 2, [-1, -1, 1, 0, 0, 1, 0, -1],
        [
            Array.Empty<int>(), [6], [5], [6], [3], Array.Empty<int>(),
            [4], Array.Empty<int>()
        ]), Is.Empty);
    }
}