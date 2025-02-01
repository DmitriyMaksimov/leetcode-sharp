using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03021Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03021();
        Assert.That(sut.FlowerGame(3, 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03021();
        Assert.That(sut.FlowerGame(1, 1), Is.EqualTo(0));
    }
    [Test]
    public void T3()
    {
        var sut = new S03021();
        Assert.That(sut.FlowerGame(58280, 69389), Is.EqualTo(2021995460));
    }
}
