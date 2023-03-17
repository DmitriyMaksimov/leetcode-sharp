using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00152Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00152();
        sut.MaxProduct(new[] {2, 3, -2, 4}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00152();
        sut.MaxProduct(new[] {-2, 0, -1}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00152();
        sut.MaxProduct(new[] {-2, 3, -4}).Should().Be(24);
    }
}