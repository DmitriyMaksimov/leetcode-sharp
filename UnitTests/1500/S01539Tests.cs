using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01539Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01539();
        Assert.That(sut.FindKthPositive(new[] {2, 3, 4, 7, 11}, 5), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01539();
        Assert.That(sut.FindKthPositive(new[] {1,2,3,4}, 2), Is.EqualTo(6));
    }
}