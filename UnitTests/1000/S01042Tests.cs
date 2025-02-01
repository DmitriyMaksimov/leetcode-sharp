using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01042Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01042();
        Assert.That(sut.GardenNoAdj(3, [[1, 2], [2, 3], [3, 1]]), Is.EqualTo((int[]) [1, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01042();
        Assert.That(sut.GardenNoAdj(4, [[1, 2], [3, 4]]), Is.EqualTo((int[]) [1, 2, 1, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01042();
        Assert.That(sut.GardenNoAdj(4, [[1, 2], [2, 3], [3, 4], [4, 1], [1, 3], [2, 4]]), Is.EqualTo((int[]) [1, 2, 3, 4]));
    }
}
