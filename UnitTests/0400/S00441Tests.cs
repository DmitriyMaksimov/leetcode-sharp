using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00441Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00441();
        sut.ArrangeCoins(5).Should().Be(2);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00441();
        sut.ArrangeCoins(8).Should().Be(3);
    }
}