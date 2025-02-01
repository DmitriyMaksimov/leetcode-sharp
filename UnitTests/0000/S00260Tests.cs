using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00260Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00260();
        Assert.That(sut.SingleNumber([1, 2, 1, 3, 2, 5]), Is.EquivalentTo((int[]) [3, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00260();
        Assert.That(sut.SingleNumber([-1, 0]), Is.EquivalentTo((int[]) [-1, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00260();
        Assert.That(sut.SingleNumber([0, 1]), Is.EquivalentTo((int[]) [0, 1]));
    }
}
