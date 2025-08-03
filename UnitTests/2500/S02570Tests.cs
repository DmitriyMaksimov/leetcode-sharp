using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02570Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02570();
        Assert.That(sut.MergeArrays(
            [[1, 2], [2, 3], [4, 5]],
            [[1, 4], [3, 2], [4, 1]]
        ), Is.EquivalentTo([[1, 6], [2, 3], [3, 2], new[] {4, 6}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02570();
        Assert.That(sut.MergeArrays(
            [[2, 4], [3, 6], [5, 5]],
            [[1, 3], [4, 3]]
        ), Is.EquivalentTo([[1, 3], [2, 4], [3, 6], [4, 3], new[] {5, 5}]));
    }
}