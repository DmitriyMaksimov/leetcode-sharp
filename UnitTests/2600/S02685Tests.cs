using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02685Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02685();
        sut.CountCompleteComponents(6, [[0, 1], [0, 2], [1, 2], [3, 4]]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02685();
        sut.CountCompleteComponents(6, [[0, 1], [0, 2], [1, 2], [3, 4], [3, 5]]).Should().Be(1);
    }
}
