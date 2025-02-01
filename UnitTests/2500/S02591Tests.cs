using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02591Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02591();
        Assert.That(sut.DistMoney(20, 3), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02591();
        Assert.That(sut.DistMoney(16, 2), Is.EqualTo(2));
    }
}