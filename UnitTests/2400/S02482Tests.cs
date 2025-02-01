using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02482Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02482();
        Assert.That(sut.OnesMinusZeros(new[] {new[] {0, 1, 1}, new[] {1, 0, 1}, new[] {0, 0, 1}}), Is.EquivalentTo(new[]
        {
            new[] {0, 0, 4},
            new[] {0, 0, 4},
            new[] {-2, -2, 2}
        }));
    }

    [Test]
    public void T2()
    {
        var sut = new S02482();
        Assert.That(sut.OnesMinusZeros(new[] {new[] {1, 1, 1}, new[] {1, 1, 1}}), Is.EquivalentTo(new[]
        {
            new[] {5, 5, 5},
            new[] {5, 5, 5}
        }));
    }
}