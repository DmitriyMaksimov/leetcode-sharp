using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03208Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03208();
        Assert.That(sut.NumberOfAlternatingGroups([0, 1, 0, 1, 0], 3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03208();
        Assert.That(sut.NumberOfAlternatingGroups([0, 1, 0, 0, 1, 0, 1], 6), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03208();
        Assert.That(sut.NumberOfAlternatingGroups([1, 1, 0, 1], 4), Is.EqualTo(0));
    }
}
