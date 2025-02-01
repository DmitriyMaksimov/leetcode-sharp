using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02251Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02251();
        Assert.That(sut.FullBloomFlowers(new[] {new[] {1, 6}, new[] {3, 7}, new[] {9, 12}, new[] {4, 13}}, new[] {2, 3, 7, 11}), Is.EqualTo((int[]) [1, 2, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02251();
        Assert.That(sut.FullBloomFlowers(new[] {new[] {1, 10}, new[] {3, 3}}, new[] {3, 3, 2}), Is.EqualTo((int[]) [2, 2, 1]));
    }
}