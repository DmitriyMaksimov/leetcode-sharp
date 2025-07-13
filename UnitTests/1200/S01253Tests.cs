using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01253))]
public class S01253Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01253();
        Assert.That(sut.ReconstructMatrix(2, 1, [1, 1, 1]), Is.EquivalentTo([
            (int[])
            [1, 0, 1],
            [0, 1, 0]
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01253();
        Assert.That(sut.ReconstructMatrix(2, 3, [2, 2, 1, 1]), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S01253();
        Assert.That(sut.ReconstructMatrix(5, 5, [2, 1, 2, 0, 1, 0, 1, 2, 0, 1]),
            Is.EquivalentTo([
                (int[])
                [1, 0, 1, 0, 1, 0, 0, 1, 0, 1],
                [1, 1, 1, 0, 0, 0, 1, 1, 0, 0]
            ]));
    }
}