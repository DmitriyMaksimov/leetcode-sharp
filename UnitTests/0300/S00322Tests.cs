using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00322Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00322();
        sut.CoinChange(new[] {1, 2, 5}, 11).Should().Be(3);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00322();
        sut.CoinChange(new[] {2}, 3).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00322();
        sut.CoinChange(new[] {1}, 0).Should().Be(0);
    }
}