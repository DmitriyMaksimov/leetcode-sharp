using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01558Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01558();
        sut.MinOperations([1, 5]).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01558();
        sut.MinOperations([2, 2]).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01558();
        sut.MinOperations([4, 2, 5]).Should().Be(6);
    }
}
