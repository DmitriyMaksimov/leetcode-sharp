using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03191Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03191();
        sut.MinOperations([0, 1, 1, 1, 0, 0]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03191();
        sut.MinOperations([0, 1, 1, 1]).Should().Be(-1);
    }
}
