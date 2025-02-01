using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02492();
        Assert.That(sut.MinScore(4, new[] {new[] {1, 2, 9}, new[] {2, 3, 6}, new[] {2, 4, 5}, new[] {1, 4, 7}}), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02492();
        Assert.That(sut.MinScore(4, new[] {new[] {1, 2, 2}, new[] {1, 3, 4}, new[] {3, 4, 7}}), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02492();
        Assert.That(sut.MinScore(14, new[]
        {
            new[] {2, 9, 2308}, new[] {2, 5, 2150}, new[] {12, 3, 4944}, new[] {13, 5, 5462}, new[] {2, 10, 2187}, new[] {2, 12, 8132}, new[] {2, 13, 3666},
            new[] {4, 14, 3019}, new[] {2, 4, 6759}, new[] {2, 14, 9869}, new[] {1, 10, 8147}, new[] {3, 4, 7971}, new[] {9, 13, 8026}, new[] {5, 12, 9982},
            new[] {10, 9, 6459}
        }), Is.EqualTo(2150));
    }
}