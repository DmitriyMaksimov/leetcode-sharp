using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03678))]
public class S03678Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03678();
        Assert.That(sut.SmallestAbsent([3, 5]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03678();
        Assert.That(sut.SmallestAbsent([-1, 1, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03678();
        Assert.That(sut.SmallestAbsent([4, -1]), Is.EqualTo(2));
    }

    [Test]
    public void T4()
    {
        var sut = new S03678();
        Assert.That(sut.SmallestAbsent([-42]), Is.EqualTo(1));
    }
}