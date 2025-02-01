using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01020Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01020();
        Assert.That(sut.NumEnclaves(
            new[]
            {
                new[] {0, 0, 0, 0},
                new[] {1, 0, 1, 0},
                new[] {0, 1, 1, 0},
                new[] {0, 0, 0, 0},
            }), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01020();
        Assert.That(sut.NumEnclaves(
            new[]
            {
                new[] {0, 1, 1, 0},
                new[] {0, 0, 1, 0},
                new[] {0, 0, 1, 0},
                new[] {0, 0, 0, 0},
            }), Is.EqualTo(0));
    }
}