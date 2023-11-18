using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02894Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02894();
        sut.DifferenceOfSums(10, 3).Should().Be(19);
    }

    [Test]
    public void T2()
    {
        var sut = new S02894();
        sut.DifferenceOfSums(5, 6).Should().Be(15);
    }

    [Test]
    public void T3()
    {
        var sut = new S02894();
        sut.DifferenceOfSums(5, 1).Should().Be(-15);
    }
}