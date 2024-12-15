using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02033Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02033();
        sut.MinOperations([[2, 4], [6, 8]], 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02033();
        sut.MinOperations([[1, 5], [2, 3]], 1).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S02033();
        sut.MinOperations([[1, 2], [3, 4]], 2).Should().Be(-1);
    }
}
