using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00373Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00373();
        var pairs = sut.KSmallestPairs(new[] {1, 7, 11}, new[] {2, 4, 6}, 3);
        pairs.Should().HaveCount(3);
        Assert.That(pairs[0], Is.EqualTo((int[]) [1, 2]));
        Assert.That(pairs[1], Is.EqualTo((int[]) [1, 4]));
        Assert.That(pairs[2], Is.EqualTo((int[]) [1, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00373();
        var pairs = sut.KSmallestPairs(new[] {1, 1, 2}, new[] {1, 2, 3}, 2);
        pairs.Should().HaveCount(2);
        Assert.That(pairs[0], Is.EqualTo((int[]) [1, 1]));
        Assert.That(pairs[1], Is.EqualTo((int[]) [1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00373();
        var pairs = sut.KSmallestPairs(new[] {1, 2}, new[] {3}, 3);
        pairs.Should().HaveCount(2);
        Assert.That(pairs[0], Is.EqualTo((int[]) [1, 3]));
        Assert.That(pairs[1], Is.EqualTo((int[]) [2, 3]));
    }
}