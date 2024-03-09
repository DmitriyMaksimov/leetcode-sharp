using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03065Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03065();
        sut.MinOperations([2, 11, 10, 1, 3], 10).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03065();
        sut.MinOperations([1, 1, 2, 4, 9], 1).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S03065();
        sut.MinOperations([1, 1, 2, 4, 9], 9).Should().Be(4);
    }
}