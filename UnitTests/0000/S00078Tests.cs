using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00078Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00078();
        Assert.That(sut.Subsets([1, 2, 3]), Is.EquivalentTo([
            [],
            [1], [2], [3],
            [1, 2], [1, 3], [2, 3],
            new[] {1, 2, 3}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00078();
        Assert.That(sut.Subsets([0]), Is.EquivalentTo([[], new[] {0}]));
    }
}