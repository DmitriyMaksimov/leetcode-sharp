using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03192Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03192();
        sut.MinOperations([0, 1, 1, 0, 1]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03192();
        sut.MinOperations([1, 0, 0, 0]).Should().Be(1);
    }
}
