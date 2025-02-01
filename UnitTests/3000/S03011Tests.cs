using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03011Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03011();
        Assert.That(sut.CanSortArray([8, 4, 2, 30, 15]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03011();
        Assert.That(sut.CanSortArray([1, 2, 3, 4, 5]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03011();
        Assert.That(sut.CanSortArray([3, 16, 8, 4, 2]), Is.False);
    }
}
