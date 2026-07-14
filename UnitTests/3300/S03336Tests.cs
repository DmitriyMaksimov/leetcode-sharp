using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03336))]
public class S03336Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03336();
        Assert.That(sut.SubsequencePairCount([1, 2, 3, 4]), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S03336();
        Assert.That(sut.SubsequencePairCount([10, 20, 30]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03336();
        Assert.That(sut.SubsequencePairCount([1, 1, 1, 1]), Is.EqualTo(50));
    }

    [Test]
    public void T4()
    {
        var sut = new S03336();
        Assert.That(sut.SubsequencePairCount([14, 13, 16, 17, 14, 17, 17, 10]), Is.EqualTo(2878));
    }
}