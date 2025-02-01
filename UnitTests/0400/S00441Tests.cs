using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00441Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00441();
        Assert.That(sut.ArrangeCoins(5), Is.EqualTo(2));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00441();
        Assert.That(sut.ArrangeCoins(8), Is.EqualTo(3));
    }
}