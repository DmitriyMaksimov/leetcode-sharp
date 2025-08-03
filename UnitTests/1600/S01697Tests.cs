using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01697Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01697();
        Assert.That(sut.DistanceLimitedPathsExist(3, [
                [0, 1, 2], [1, 2, 4], [2, 0, 8], [1, 0, 16]
            ],
            [[0, 1, 2], [0, 2, 5]]), Is.EqualTo((bool[]) [false, true]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01697();
        Assert.That(sut.DistanceLimitedPathsExist(5, [
                [0, 1, 10], [1, 2, 5], [2, 3, 9], [3, 4, 13]
            ],
            [[0, 4, 14], [1, 4, 13]]), Is.EqualTo((bool[]) [true, false]));
    }
}
