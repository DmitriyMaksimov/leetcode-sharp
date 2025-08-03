using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01828Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01828();
        Assert.That(sut.CountPoints([[1, 3], [3, 3], [5, 3], [2, 2]],
            [[2, 3, 1], [4, 3, 1], [1, 1, 2]]), Is.EqualTo((int[]) [3, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01828();
        Assert.That(sut.CountPoints([[1, 1], [2, 2], [3, 3], [4, 4], [5, 5]],
            [[1, 2, 2], [2, 2, 2], [4, 3, 2], [4, 3, 3]]), Is.EqualTo((int[]) [2, 3, 2, 4]));
    }
}