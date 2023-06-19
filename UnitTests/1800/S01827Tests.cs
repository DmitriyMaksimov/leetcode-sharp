using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01827Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01827();
        sut.MinOperations(new[] {1, 1, 1}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01827();
        sut.MinOperations(new[] {1, 5, 2, 4, 1}).Should().Be(14);
    }

    [Test]
    public void T3()
    {
        var sut = new S01827();
        sut.MinOperations(new[] {8}).Should().Be(0);
    }
}