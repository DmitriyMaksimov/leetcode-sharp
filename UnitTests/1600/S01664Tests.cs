using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01664Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01664();
        sut.WaysToMakeFair([2, 1, 6, 4]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01664();
        sut.WaysToMakeFair([1, 1, 1]).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01664();
        sut.WaysToMakeFair([1, 2, 3]).Should().Be(0);
    }
}
