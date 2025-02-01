using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02225Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S02225();
        Assert.That(sut.FindWinners(new[] {new[] {1, 3}, new[] {2, 3}, new[] {3, 6}, new[] {5, 6}, new[] {5, 7}, new[] {4, 5}, new[] {4, 8}, new[] {4, 9}, new[] {10, 4}, new[] {10, 9}}), Is.EquivalentTo(new[] {new[] {1, 2, 10}, new[] {4, 5, 7, 8}}));
    }

    [Test]
    public void Test2()
    {
        var sut = new S02225();
        Assert.That(sut.FindWinners(new[] {new[] {2, 3}, new[] {1, 3}, new[] {5, 4}, new[] {6, 4}}), Is.EquivalentTo(new[] {new[] {1, 2, 5, 6}, new int[] {}}));
    }
}