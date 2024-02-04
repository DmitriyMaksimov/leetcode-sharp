using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S100214Tests
{
    [Test]
    public void T1()
    {
        var sut = new S100214();
        sut.ReturnToBoundaryCount([2, 3, -5]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S100214();
        sut.ReturnToBoundaryCount([3, 2, -3, -4]).Should().Be(0);
    }
}