using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00046Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00046();
        Assert.That(sut.Permute([1, 2, 3]), Is.EquivalentTo([
            [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], new[] {3, 2, 1}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00046();
        Assert.That(sut.Permute([0, 1]), Is.EquivalentTo([[0, 1], new[] {1, 0}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00046();
        Assert.That(sut.Permute([1]), Is.EquivalentTo([new[] {1}]));
    }
}