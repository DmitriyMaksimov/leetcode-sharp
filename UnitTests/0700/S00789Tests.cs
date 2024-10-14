using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00789Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00789();
        sut.EscapeGhosts([[1, 0], [0, 3]], [0, 1]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00789();
        sut.EscapeGhosts([[1, 0]], [2, 0]).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00789();
        sut.EscapeGhosts([[2, 0]], [1, 0]).Should().BeFalse();
    }
}
