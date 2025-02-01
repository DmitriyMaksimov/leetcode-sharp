using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01899Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01899();
        Assert.That(sut.MergeTriplets([[2, 5, 3], [1, 8, 4], [1, 7, 5]], [2, 7, 5]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01899();
        Assert.That(sut.MergeTriplets([[3, 4, 5], [4, 5, 6]], [3, 2, 5]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01899();
        Assert.That(sut.MergeTriplets([[2, 5, 3], [2, 3, 4], [1, 2, 5], [5, 2, 3]], [5, 5, 5]), Is.True);
    }
}
