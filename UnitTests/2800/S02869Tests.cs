using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02869Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02869();
        sut.MinOperations(new[] {3, 1, 5, 4, 2}, 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02869();
        sut.MinOperations(new[] {3, 1, 5, 4, 2}, 5).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S02869();
        sut.MinOperations(new[] {3, 2, 5, 3, 1}, 3).Should().Be(4);
    }
}