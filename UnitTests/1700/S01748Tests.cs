using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01748Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01748();
        sut.SumOfUnique(new[] {1, 2, 3, 2}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01748();
        sut.SumOfUnique(new[] {1, 1, 1, 1, 1}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01748();
        sut.SumOfUnique(new[] {1, 2, 3, 4, 5}).Should().Be(15);
    }
}