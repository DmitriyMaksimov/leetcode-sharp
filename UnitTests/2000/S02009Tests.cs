using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02009Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02009();
        sut.MinOperations(new[] {4, 2, 5, 3}).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02009();
        sut.MinOperations(new[] {1, 2, 3, 5, 6}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02009();
        sut.MinOperations(new[] {1, 10, 100, 1000}).Should().Be(3);
    }

    [Test]
    public void T4()
    {
        var sut = new S02009();
        sut.MinOperations(new[] {8, 10, 16, 18, 10, 10, 16, 13, 13, 16}).Should().Be(6);
    }
}