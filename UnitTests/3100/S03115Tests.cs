using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03115Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03115();
        sut.MaximumPrimeDifference([4, 2, 9, 5, 3]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03115();
        sut.MaximumPrimeDifference([4, 8, 2, 8]).Should().Be(0);
    }
}