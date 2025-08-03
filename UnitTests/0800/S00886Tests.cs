using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00886Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00886();
        Assert.That(sut.PossibleBipartition(4, [[1, 2], [1, 3], [2, 4]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00886();
        Assert.That(sut.PossibleBipartition(3, [[1, 2], [1, 3], [2, 3]]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00886();
        Assert.That(sut.PossibleBipartition(5, [[1, 2], [2, 3], [3, 4], [4, 5], [1, 5]]), Is.False);
    }

    [Test]
    public void T4()
    {
        var sut = new S00886();
        Assert.That(sut.PossibleBipartition(5, [[1, 2], [1, 3], [1, 4], [1, 5], [1, 5]]), Is.True);
    }

    [Test]
    public void T5()
    {
        var sut = new S00886();
        Assert.That(sut.PossibleBipartition(10, [
            [5, 9], [5, 10], [5, 6], [5, 7], [1, 5], [4, 5], [2, 5], [5, 8], [3, 5]
        ]), Is.True);
    }
}
