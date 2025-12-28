using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03697))]
public class S03697Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03697();
        Assert.That(sut.DecimalRepresentation(537), Is.EqualTo([500, 30, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03697();
        Assert.That(sut.DecimalRepresentation(102), Is.EqualTo([100, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03697();
        Assert.That(sut.DecimalRepresentation(6), Is.EqualTo([6]));
    }
}