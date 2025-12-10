using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03583))]
public class S03583Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03583();
        Assert.That(sut.SpecialTriplets([6, 3, 6]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03583();
        Assert.That(sut.SpecialTriplets([0, 1, 0, 0]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03583();
        Assert.That(sut.SpecialTriplets([8, 4, 2, 8, 4]), Is.EqualTo(2));
    }
}