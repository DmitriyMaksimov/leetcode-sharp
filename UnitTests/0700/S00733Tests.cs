using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00733Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00733();
        Assert.That(sut.FloodFill([[1, 1, 1], [1, 1, 0], [1, 0, 1]], 1, 1, 2), Is.EquivalentTo([
            [2, 2, 2], [2, 2, 0], new[] {2, 0, 1}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00733();
        Assert.That(sut.FloodFill([[0, 0, 0], [0, 0, 0]], 0, 0, 0), Is.EquivalentTo([[0, 0, 0], new[] {0, 0, 0}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00733();
        Assert.That(sut.FloodFill([[0, 0, 0], [1, 0, 0]], 1, 0, 2), Is.EquivalentTo([[0, 0, 0], new[] {2, 0, 0}]));
    }
}