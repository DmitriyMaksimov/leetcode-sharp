using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03270Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03270();
        sut.GenerateKey(1, 10, 1000).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S03270();
        sut.GenerateKey(987, 879, 798).Should().Be(777);
    }

    [Test]
    public void T3()
    {
        var sut = new S03270();
        sut.GenerateKey(1, 2, 3).Should().Be(1);
    }
}
