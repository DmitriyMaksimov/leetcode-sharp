using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03021Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03021();
        sut.FlowerGame(3, 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03021();
        sut.FlowerGame(1, 1).Should().Be(0);
    }
    [Test]
    public void T3()
    {
        var sut = new S03021();
        sut.FlowerGame(58280, 69389).Should().Be(2021995460);
    }
}
