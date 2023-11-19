using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02932Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02932();
        sut.MaximumStrongPairXor(new[] {1, 2, 3, 4, 5}).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S02932();
        sut.MaximumStrongPairXor(new[] {10, 100}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02932();
        sut.MaximumStrongPairXor(new[] {5, 6, 25, 30}).Should().Be(7);
    }
}