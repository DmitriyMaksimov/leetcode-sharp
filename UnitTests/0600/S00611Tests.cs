using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00611Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00611();
        sut.TriangleNumber([2, 2, 3, 4]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00611();
        sut.TriangleNumber([4, 2, 3, 4]).Should().Be(4);
    }
}
