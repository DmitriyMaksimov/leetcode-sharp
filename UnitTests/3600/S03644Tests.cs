using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03644))]
public class S03644Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03644();
        Assert.That(sut.SortPermutation([0, 3, 2, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03644();
        Assert.That(sut.SortPermutation([0, 1, 3, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03644();
        Assert.That(sut.SortPermutation([3, 2, 1, 0]), Is.Zero);
    }
}