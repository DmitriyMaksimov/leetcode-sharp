using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02614Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02614();
        sut.DiagonalPrime(new[] {new[] {1, 2, 3}, new[] {5, 6, 7}, new[] {9, 10, 11}}).Should().Be(11);
    }

    [Test]
    public void T2()
    {
        var sut = new S02614();
        sut.DiagonalPrime(new[] {new[] {1, 2, 3}, new[] {5, 17, 7}, new[] {9, 11, 10}}).Should().Be(17);
    }
}