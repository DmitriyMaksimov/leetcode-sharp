using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02971Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02971();
        sut.LargestPerimeter([5, 5, 5]).Should().Be(15);
    }

    [Test]
    public void T2()
    {
        var sut = new S02971();
        sut.LargestPerimeter([1, 12, 1, 2, 5, 50, 3]).Should().Be(12);
    }

    [Test]
    public void T3()
    {
        var sut = new S02971();
        sut.LargestPerimeter([5, 5, 50]).Should().Be(-1);
    }
}