using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00695Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00695();
        Assert.That(sut.MaxAreaOfIsland(new[]
            {
                new[] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new[] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                new[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                new[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
                new[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}
            }), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00695();
        Assert.That(sut.MaxAreaOfIsland(new[] {new[] {0, 0, 0, 0, 0, 0, 0, 0}}), Is.EqualTo(0));
    }
}