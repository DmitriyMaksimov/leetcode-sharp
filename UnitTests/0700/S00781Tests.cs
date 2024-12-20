using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00781Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00781();
        sut.NumRabbits([1, 1, 2]).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00781();
        sut.NumRabbits([10, 10, 10]).Should().Be(11);
    }
}
