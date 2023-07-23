using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02466Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02466();
        sut.CountGoodStrings(3, 3, 1, 1).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S02466();
        sut.CountGoodStrings(2, 3, 1, 2).Should().Be(5);
    }
}