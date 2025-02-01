using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02070Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02070();
        Assert.That(sut.MaximumBeauty([[1, 2], [3, 2], [2, 4], [5, 6], [3, 5]], [1, 2, 3, 4, 5, 6]), Is.EqualTo((int[]) [2, 4, 5, 5, 6, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02070();
        Assert.That(sut.MaximumBeauty([[1, 2], [1, 2], [1, 3], [1, 4]], [1]), Is.EqualTo((int[]) [4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02070();
        Assert.That(sut.MaximumBeauty([[10, 1000]], [5]), Is.EqualTo((int[]) [0]));
    }
}