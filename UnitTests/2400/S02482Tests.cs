using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02482Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02482();
        Assert.That(sut.OnesMinusZeros([[0, 1, 1], [1, 0, 1], [0, 0, 1]]), Is.EquivalentTo([
            [0, 0, 4],
            [0, 0, 4],
            new[] {-2, -2, 2}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02482();
        Assert.That(sut.OnesMinusZeros([[1, 1, 1], [1, 1, 1]]), Is.EquivalentTo([
            [5, 5, 5],
            new[] {5, 5, 5}
        ]));
    }
}