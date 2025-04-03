using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02874Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02874();
        Assert.That(sut.MaximumTripletValue([12, 6, 1, 2, 7]), Is.EqualTo(77));
    }

    [Test]
    public void T2()
    {
        var sut = new S02874();
        Assert.That(sut.MaximumTripletValue([1, 10, 3, 4, 19]), Is.EqualTo(133));
    }

    [Test]
    public void T3()
    {
        var sut = new S02874();
        Assert.That(sut.MaximumTripletValue([1, 2, 3]), Is.EqualTo(0));
    }
}
