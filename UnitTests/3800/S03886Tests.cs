using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03886))]
public class S03886Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03886();
        Assert.That(sut.SortableIntegers([3, 1, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03886();
        Assert.That(sut.SortableIntegers([7, 6, 5]), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S03886();
        Assert.That(sut.SortableIntegers([5, 8]), Is.EqualTo(3));
    }
}