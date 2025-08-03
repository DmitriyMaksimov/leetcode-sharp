using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00797Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00797();
        Assert.That(sut.AllPathsSourceTarget([[1, 2], [3], [3], []]), Is.EquivalentTo([
            [0, 1, 3], new[] {0, 2, 3}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00797();
        Assert.That(sut.AllPathsSourceTarget([
            [4, 3, 1], [3, 2, 4], [3], [4], []
        ]), Is.EquivalentTo([[0, 4], [0, 3, 4], [0, 1, 3, 4], [0, 1, 2, 3, 4], new[] {0, 1, 4}]));
    }
}