using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00565Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00565();
        sut.ArrayNesting([5, 4, 0, 3, 1, 6, 2]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00565();
        sut.ArrayNesting([0, 1, 2]).Should().Be(1);
    }
}
