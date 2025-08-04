using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03638))]
public class S03638Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03638();
        Assert.That(sut.MaxBalancedShipments([2, 5, 1, 4, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03638();
        Assert.That(sut.MaxBalancedShipments([4, 4]), Is.EqualTo(0));
    }
}