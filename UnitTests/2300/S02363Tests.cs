using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02363Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02363();
        Assert.That(sut.MergeSimilarItems([[1, 1], [4, 5], [3, 8]], [[3, 1], [1, 5]]), Is.EquivalentTo([
            [1, 6], [3, 9], new[] {4, 5}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02363();
        Assert.That(sut.MergeSimilarItems([[1, 1], [3, 2], [2, 3]],
            [[2, 1], [3, 2], [1, 3]]), Is.EquivalentTo([[1, 4], [2, 4], new[] {3, 4}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02363();
        Assert.That(sut.MergeSimilarItems([[1, 3], [2, 2]], [[7, 1], [2, 2], [1, 4]]), Is.EquivalentTo([
            [1, 7], [2, 4], new[] {7, 1}
        ]));
    }
}