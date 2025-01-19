using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03423();
        sut.MaxAdjacentDistance([1, 2, 4]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03423();
        sut.MaxAdjacentDistance([-5, -10, -5]).Should().Be(5);
    }
}
