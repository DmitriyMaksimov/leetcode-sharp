using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01636Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01636();
        Assert.That(sut.FrequencySort([1, 1, 2, 2, 2, 3]), Is.EqualTo((int[]) [3, 1, 1, 2, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01636();
        Assert.That(sut.FrequencySort([2, 3, 1, 3, 2]), Is.EqualTo((int[]) [1, 3, 3, 2, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01636();
        Assert.That(sut.FrequencySort([-1, 1, -6, 4, 5, -6, 1, 4, 1]), Is.EqualTo((int[]) [5, -1, 4, 4, -6, -6, 1, 1, 1]));
    }
}