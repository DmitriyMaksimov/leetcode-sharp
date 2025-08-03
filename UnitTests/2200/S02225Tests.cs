using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02225Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S02225();
        Assert.That(sut.FindWinners([
            [1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]
        ]), Is.EquivalentTo([[1, 2, 10], new[] {4, 5, 7, 8}]));
    }

    [Test]
    public void Test2()
    {
        var sut = new S02225();
        Assert.That(sut.FindWinners([[2, 3], [1, 3], [5, 4], [6, 4]]), Is.EquivalentTo([
            [1, 2, 5, 6], new int[] {}
        ]));
    }
}