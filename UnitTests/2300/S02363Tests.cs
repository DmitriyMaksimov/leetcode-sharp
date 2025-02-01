using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02363Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02363();
        Assert.That(sut.MergeSimilarItems(new[] {new[] {1, 1}, new[] {4, 5}, new[] {3, 8}}, new[] {new[] {3, 1}, new[] {1, 5}}), Is.EquivalentTo(new[] {new[] {1, 6}, new[] {3, 9}, new[] {4, 5}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S02363();
        Assert.That(sut.MergeSimilarItems(new[] {new[] {1, 1}, new[] {3, 2}, new[] {2, 3}},
                new[] {new[] {2, 1}, new[] {3, 2}, new[] {1, 3}}), Is.EquivalentTo(new[] {new[] {1, 4}, new[] {2, 4}, new[] {3, 4}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S02363();
        Assert.That(sut.MergeSimilarItems(new[] {new[] {1, 3}, new[] {2, 2}}, new[] {new[] {7, 1}, new[] {2, 2}, new[] {1, 4}}), Is.EquivalentTo(new[] {new[] {1, 7}, new[] {2, 4}, new[] {7, 1}}));
    }
}