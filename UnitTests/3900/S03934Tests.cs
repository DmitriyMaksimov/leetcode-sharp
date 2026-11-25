using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03934))]
public class S03934Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03934();
        Assert.That(sut.SmallestUniqueSubarray([3, 3, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03934();
        Assert.That(sut.SmallestUniqueSubarray([2, 1, 2, 3, 3]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03934();
        Assert.That(sut.SmallestUniqueSubarray([1, 1, 2, 2, 1]), Is.EqualTo(2));
    }
}