using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01658Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01658();
        sut.MinOperations(new[] {1, 1, 4, 2, 3}, 5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01658();
        sut.MinOperations(new[] {5, 6, 7, 8, 9}, 4).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01658();
        sut.MinOperations(new[] {3, 2, 20, 1, 1, 3}, 10).Should().Be(5);
    }
}