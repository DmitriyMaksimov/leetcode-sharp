using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02322))]
public class S02322Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02322();
        Assert.That(sut.MinimumScore([1, 5, 5, 4, 11], [[0, 1], [1, 2], [1, 3], [3, 4]]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02322();
        Assert.That(sut.MinimumScore([5, 5, 2, 4, 4, 2], [[0, 1], [1, 2], [5, 2], [4, 3], [1, 3]]), Is.EqualTo(0));
    }
}