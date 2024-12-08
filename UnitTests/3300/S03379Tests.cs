using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03379Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03379();
        sut.ConstructTransformedArray([3, -2, 1, 1]).Should().Equal(1, 1, 1, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03379();
        sut.ConstructTransformedArray([-1, 4, -1]).Should().Equal(-1, -1, 4);
    }

    [Test]
    public void T3()
    {
        var sut = new S03379();
        sut.ConstructTransformedArray([-10, -10]).Should().Equal(-10, -10);
    }
}
